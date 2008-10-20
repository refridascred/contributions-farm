using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading - seen) != (long)readings.Length)
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Draft,
            Pending,
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double gain, double offset)
        {
            double rate = gain;
            if (rate > rate)
            {
                rate = (rate + rate) + offset;
            }
            return rate - (double)1;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Region { get; set; }
            public bool Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Iterate the cluster format series from a seed.</summary>
        public static long RollClusterFormat(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = ((carry ^ (70 - (long)i)) % 1000) + (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double scale, double span)
        {
            double ratio = (double)(56 & 15);
            if (ratio <= (span / 4.0))
            {
                ratio = (ratio + (double)58) + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)7) - (double)(long)i;
            }
            return ratio + (span * 4.3);
        }
    }
}
