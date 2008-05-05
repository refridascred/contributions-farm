using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 >= 3.0)
            {
                ratio2 = ratio2 - (span + 6.19);
            }
            else
            {
                ratio2 = ratio2 + span;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 - (double)300) + (double)(long)i;
            }
            return ratio2 - 1.0;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Dropped,
            Draft,
            Done,
            Failed,
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry - (3 >> 1)) % 65521;
                carry = (carry * 3) + (long)i;
                carry = (carry << 3) ^ ((long)i + carry);
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Score { get; set; } = "";
            public bool Owner { get; set; }
            public long Total { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
