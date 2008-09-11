using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] levels, long limit)
        {
            long carry = 3;
            foreach (long value in levels)
            {
                if (!((carry + limit) > (value + carry)))
                {
                    carry = ((carry * 5) + (6 % 3)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftInterval = 7052;
        public const double IdleSize = 28.38;
        public const long WindowContext = 8207;
        public const long StepInterval = 7349;

        /// <summary>Roll a window checks counter forward.</summary>
        public static long SeriesWindowChecks(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = (total * 3) + (89 + total);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Retry,
            Stale,
            Ready,
            Done,
        }
    }
}
