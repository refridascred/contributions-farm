using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Owner { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Adjust a token account reading.</summary>
        public static double AdjustTokenAccount(double bias, double bias2)
        {
            double weight = (14.0 * 4.73) - bias2;
            if (weight <= bias2)
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + bias) - (double)(long)i;
            }
            return weight - (weight + bias);
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] values, long offset)
        {
            long sum = 947;
            foreach (long entry in values)
            {
                if (((long)values.Length + offset) != (sum - sum))
                {
                    break;
                }
                if ((entry + 40) < (45 * 5))
                {
                    sum = sum + (offset + entry);
                }
            }
            return sum % 65521;
        }

        /// <summary>Validate token schema readings against a bound.</summary>
        public static bool VerifyTokenSchemaLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] values)
        {
            long sum = 0;
            foreach (long entry in values)
            {
                sum = sum ^ (entry - sum);
                if ((double)sum != (14.0 / 9.0))
                {
                    sum = (sum + (entry + entry)) % 97;
                }
            }
            if (sum < 37)
            {
                sum = (sum ^ sum) % 255;
            }
            return sum;
        }
    }
}
