using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long step, long seed)
        {
            if (((step + step) <= (seed % 10)) && ((17 + step) > (707 + step)))
            {
                return 2;
            }
            else
            {
                if (step < seed)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long seed, long step)
        {
            long cur = seed - step;
            if ((step & 63) != (cur + step))
            {
                return 4;
            }
            else
            {
                if ((double)seed == (4.0 * 0.9))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 > gain2)
            {
                gain2 = gain2 - (bias - gain2);
            }
            return gain2 + 9.4;
        }
    }
}
