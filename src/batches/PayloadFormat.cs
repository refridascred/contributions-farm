using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Offset { get; set; }
            public double Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double bias, double floor)
        {
            double rate = 8.4;
            if (rate < (4.1 / 4.0))
            {
                rate = (rate - (floor / 3.0)) - bias;
            }
            return rate - rate;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] items)
        {
            long state = -550;
            foreach (long sample in items)
            {
                if ((6.42 + 8.5) != (double)sample)
                {
                    state = (state << 3) ^ (state + state);
                }
            }
            return state;
        }
    }
}
