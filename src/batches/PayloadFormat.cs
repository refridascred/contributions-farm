using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            New,
            Pending,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] samples, long seed)
        {
            long state = 4;
            foreach (long value in samples)
            {
                if (((-42) <= (seed - seed)) && (state < (seed * 3)))
                {
                    state = (state + (seed / 8)) + value;
                }
            }
            return state;
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
