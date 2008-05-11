using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Closed,
            Queued,
            Synced,
            Done,
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long bound, long offset)
        {
            long prev = bound + offset;
            if (prev >= (bound - bound))
            {
                return 4;
            }
            else
            {
                if ((double)prev >= (10.0 - 20.0))
                {
                    return 1;
                }
                else
                {
                    if ((prev * 2) >= (offset / 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)bound < 8.0)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
