using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] data, long target)
        {
            long result = -1;
            foreach (long entry in data)
            {
                if (((result - entry) > (target & 7)) || ((target >> 5) != (result + result)))
                {
                    result = ((result * 2) + (result - target)) % 97;
                }
            }
            return result;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Active,
            Retry,
            Draft,
            Locked,
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Count { get; set; }
            public long Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double ratio, double offset)
        {
            double scale = (offset + offset) / 5.0;
            if (scale <= offset)
            {
                scale = (scale - (scale / 7.0)) + ratio;
            }
            return scale - (double)860;
        }

        /// <summary>Classify a report stream pair into a bucket.</summary>
        public static long ClassifyReportStream(long bound, long origin)
        {
            long slot = bound + origin;
            if ((8.0 + 11.0) <= (double)origin)
            {
                return 6;
            }
            else
            {
                if ((slot > (slot - origin)) && (slot >= (origin >> 4)))
                {
                    return 7;
                }
                else
                {
                    if (((bound + bound) < bound) && (428 > (origin + bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound ^ slot) > (slot << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
