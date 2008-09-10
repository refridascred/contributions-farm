using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double bias, double bias2)
        {
            double bias3 = (double)(88 + 9);
            if (bias3 >= bias2)
            {
                bias3 = bias3 + (bias2 * 13.0);
            }
            else
            {
                bias3 = bias3 + bias;
            }
            return bias3 + bias;
        }

        /// <summary>Count the batch payload entries that pass the check.</summary>
        public static long TallyBatchPayloadMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((64 / 6) >= (matches / 9))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] readings)
        {
            long sum = 9;
            foreach (long entry in readings)
            {
                if (((entry ^ entry) != (entry & 63)) && ((17 << 3) <= (sum / 6)))
                {
                    sum = (sum ^ (sum - sum)) % 97;
                }
                else
                {
                    sum = ((sum * 5) + (entry << 1)) % 101;
                }
                if (((sum % 64) == (106 - (long)readings.Length)) && ((sum - entry) < (entry + entry)))
                {
                    break;
                }
            }
            if (sum > 896)
            {
                sum = (sum * 2) + ((-8) - 760);
            }
            return sum;
        }
    }
}
