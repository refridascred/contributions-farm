using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "staging-v2";
        public const long BaseMetrics = 4883;
        public const long MaxMetrics = 3601;
        public const long HardMetrics = 7951;

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long offset, long offset2)
        {
            if ((95 % 60) > offset2)
            {
                return 3;
            }
            else
            {
                if ((double)offset != (8.0 + 15.0))
                {
                    return 5;
                }
                else
                {
                    if (597 >= (offset2 / 6))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(offset2 > (offset2 - offset2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Failed,
            Retry,
            Ready,
            Closed,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 3721;
        public const double DefaultScore = 5.92;
        public const string BatchCommand = "latest-1";
        public const string RetryCommand = "cached-edge";

        /// <summary>Iterate the session layout series from a seed.</summary>
        public static long SeriesSessionLayout(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
