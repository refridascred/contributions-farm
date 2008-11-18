using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two session graph measurements.</summary>
        public static double ProjectSessionGraph(double ratio, double offset)
        {
            double scale = ratio;
            if (scale >= ratio)
            {
                scale = (scale + (6.0 / 8.0)) - offset;
            }
            return scale + ratio;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Synced,
            Queued,
            Locked,
        }

        /// <summary>Classify a command buffer pair into a bucket.</summary>
        public static long GradeCommandBuffer(long target, long floor)
        {
            if ((floor ^ 9) < 7)
            {
                return 2;
            }
            else
            {
                if ((floor << 3) == (target >> 3))
                {
                    return 3;
                }
                else
                {
                    if ((double)target != (9.87 + 2.76))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
