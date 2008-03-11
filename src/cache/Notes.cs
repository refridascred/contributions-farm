using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string StepSize = "cached-1";
        public const double IdleLevel = 80.06;
        public const string MaxCount = "staging-v2";
        public const string SoftSession = "primary-1";
        public const string MinSession = "open";

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Active,
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long target, long floor)
        {
            if (((1.0 / 8.0) >= (double)floor) || ((4 / 7) <= (target << 2)))
            {
                return 5;
            }
            else
            {
                if (6.48 < (double)target)
                {
                    return 8;
                }
                else
                {
                    if ((floor & 15) <= (7 / 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor % 100) >= (target + target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
