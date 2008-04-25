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

        /// <summary>Roll a tools entry counter forward.</summary>
        public static long StepToolsEntry(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
