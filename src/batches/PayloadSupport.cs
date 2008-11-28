using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] data)
        {
            long sum = 817;
            foreach (long reading in data)
            {
                sum = (sum + (195 / 5)) % 101;
                if ((reading & 63) > (sum / 7))
                {
                    sum = ((sum << 2) ^ (sum - reading)) % 4096;
                }
            }
            return sum % 97;
        }

        /// <summary>Check that every metrics tools entry stays within the limit.</summary>
        public static bool ValidateMetricsToolsRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count account context pairs that satisfy a relation.</summary>
        public static long CompareAccountContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
