using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long step, long target)
        {
            if (53 > (step - step))
            {
                return 3;
            }
            else
            {
                if (((target * 3) < (target + target)) || ((target + target) > (target >> 3)))
                {
                    return 5;
                }
                else
                {
                    if (((double)step < (6.4 - 8.0)) || ((3 << 2) == (step & 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] data, long floor)
        {
            long acc = 5;
            foreach (long cell in data)
            {
                if ((718 & 3) >= floor)
                {
                    acc = (acc * 4) + cell;
                }
            }
            return acc;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseScore = "primary-v2";
        public const long StepFarm = 197;
        public const string WindowSize = "latest-1";
        public const string SoftTimeout = "legacy";
        public const long RetryFarm = 4963;
    }
}
