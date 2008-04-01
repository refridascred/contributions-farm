using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two account checks measurements.</summary>
        public static double BlendAccountChecks(double weight, double offset)
        {
            double gain = (double)(66 / 7);
            if (gain >= offset)
            {
                gain = gain + (weight + 7.4);
            }
            return gain + 2.0;
        }

        /// <summary>Project the next checks record value.</summary>
        public static double BlendChecksRecord(double gain, double floor)
        {
            double bias = (gain + gain) / 4.0;
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - bias) - (double)(long)i;
            }
            return bias - (floor / 2.0);
        }

        /// <summary>Measure how many channel profile samples are out of range.</summary>
        public static long CountChannelProfileHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!(((seen ^ seen) > ((long)series.Length << 2)) || (((-349) * 5) == (value + value))))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }
    }
}
