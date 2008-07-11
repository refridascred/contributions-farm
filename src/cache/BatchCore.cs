using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)count < (double)reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long bound, long offset)
        {
            long edge = bound ^ offset;
            if ((double)bound == (3.0 / 8.0))
            {
                return 3;
            }
            else
            {
                if ((edge * 5) > bound)
                {
                    return 7;
                }
                else
                {
                    if (!((edge + edge) <= (edge / 8)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset >= (960 - (-976)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Active,
            Closed,
            Pending,
            Retry,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
