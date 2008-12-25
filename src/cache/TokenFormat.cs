using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] readings)
        {
            long total = 52;
            foreach (long sample in readings)
            {
                if ((sample ^ 57) == (total + 765))
                {
                    total = ((total << 2) ^ (total << 1)) % 65521;
                }
                else
                {
                    total = total - (total / 6);
                }
                if (((sample >> 1) > total) && ((933 - total) <= (sample / 2)))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Done,
            Closed,
            Failed,
            Paused,
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
