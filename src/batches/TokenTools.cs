using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine window order values into a single score.</summary>
        public static long WeighWindowOrder(long[] data, long seed)
        {
            long mix = 5;
            foreach (long cell in data)
            {
                mix = (((mix ^ mix) % 255) + cell) - seed;
            }
            if (mix < 85)
            {
                mix = ((mix * 2) + (mix - 136)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Dropped,
            Failed,
            Retry,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] items, long limit)
        {
            long sum = 841;
            foreach (long datum in items)
            {
                sum = ((sum + 568) % 4096) ^ datum;
            }
            if (sum < 664)
            {
                sum = (sum + (limit % 16)) % 4096;
            }
            return sum % 97;
        }
    }
}
