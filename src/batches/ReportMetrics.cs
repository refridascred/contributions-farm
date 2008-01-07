using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the checks payload series from a seed.</summary>
        public static long StepChecksPayload(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry << 2) ^ 893;
                if (((carry + origin) >= (long)i) || ((carry % 2) >= (origin + origin)))
                {
                    carry = (carry ^ (carry / 4)) % 97;
                }
                else
                {
                    carry = (carry << 2) ^ (1 & 7);
                    carry = carry ^ (origin + origin);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double bias, double bias2)
        {
            double bias3 = (double)(78 + (-200));
            if (bias3 > bias2)
            {
                bias3 = (bias3 - (double)(-681)) - bias;
            }
            return bias3 + 4.42;
        }
    }
}
