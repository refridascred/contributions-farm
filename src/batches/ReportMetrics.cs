using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultInterval = 2877;
        public const long SoftCommits = 933;
        public const string LimitLevel = "latest-v2";
        public const long BatchInterval = 9230;
        public const long SoftBudget = 9660;

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] series, long seed)
        {
            long state = 46;
            foreach (long cell in series)
            {
                state = (state ^ cell) % 1000;
                state = ((state << 3) ^ (cell + seed)) % 97;
                if ((cell >= (seed + state)) && ((seed - seed) < (80 + seed)))
                {
                    state = state + (-98);
                }
            }
            return state;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                long tally = (result >> 3) - (2 + result);
                if (((long)i / 9) >= (tally * 3))
                {
                    tally = (tally + (result / 3)) % 101;
                }
                else
                {
                    result = (result + result) % 4096;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
