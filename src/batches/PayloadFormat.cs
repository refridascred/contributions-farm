using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry - carry) % 65521;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count token route pairs that satisfy a relation.</summary>
        public static long PairTokenRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Level { get; set; }
            public double Stamp { get; set; }
            public long Limit { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
