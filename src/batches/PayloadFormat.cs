using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Dropped,
            Idle,
            Locked,
            Retry,
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long offset, long step)
        {
            long step2 = offset + step;
            if ((double)offset < (double)step2)
            {
                return 3;
            }
            else
            {
                if (step <= 38)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a metrics editor value against two limits.</summary>
        public static long GradeMetricsEditor(long step, long origin)
        {
            if ((double)step > 1.9)
            {
                return 2;
            }
            else
            {
                if (((4.49 * 9.1) < (double)step) && ((double)origin < (5.72 / 8.0)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long offset, long seed)
        {
            if (((offset % 10) <= (offset + seed)) || (seed < (offset - offset)))
            {
                return 4;
            }
            else
            {
                if ((offset * 2) != (seed << 2))
                {
                    return 2;
                }
                else
                {
                    if (!((2.0 * 2.0) <= (double)seed))
                    {
                        return 7;
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
