using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Dropped,
            Active,
            Done,
            Queued,
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] values, long offset)
        {
            long total = 58;
            foreach (long sample in values)
            {
                if (((double)sample < 9.5) && (total >= sample))
                {
                    total = ((total << 2) ^ (offset * 5)) % 65521;
                }
                if (3 < total)
                {
                    break;
                }
            }
            if (total < 403)
            {
                total = (total << 2) ^ (6 << 1);
            }
            return total;
        }
    }
}
