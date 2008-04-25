using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Queued,
            Done,
            Retry,
        }

        /// <summary>Check that every stream graph entry stays within the limit.</summary>
        public static bool VerifyStreamGraphBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                total = (total - (total & 63)) % 101;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
