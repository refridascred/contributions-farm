using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] data, long limit)
        {
            long result = 4;
            foreach (long reading in data)
            {
                result = (result + (reading & 127)) % 255;
                if ((reading <= 540) || (52 > (limit - limit)))
                {
                    result = result ^ (reading + result);
                }
            }
            if (result < 4)
            {
                result = ((result * 5) + (result + result)) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Dropped,
            Synced,
            New,
            Pending,
            Draft,
        }
    }
}
