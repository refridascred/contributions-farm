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

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
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
