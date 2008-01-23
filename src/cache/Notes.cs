using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftScore = 7357;
        public const long MaxCache = 2877;
        public const string WindowBudget = "fallback";
        public const long DefaultCache = 4887;

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] values, long floor)
        {
            long score = 609;
            foreach (long cell in values)
            {
                if ((cell << 2) >= floor)
                {
                    score = ((score * 4) + (floor + cell)) % 65521;
                }
                else
                {
                    score = score - (cell / 6);
                }
            }
            if (score < 282)
            {
                score = (score - score) % 101;
            }
            return score % 97;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Iterate the channel record series from a seed.</summary>
        public static long DeriveChannelRecord(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                if (!((long)i == (floor ^ acc)))
                {
                    acc = acc ^ (acc >> 1);
                    continue;
                }
                if ((floor ^ (long)i) == ((-8) & 15))
                {
                    continue;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((5.0 + 10.0) == (double)tally)
                {
                    tally = ((tally + 3) + sample) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
