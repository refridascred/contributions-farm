using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count window farm pairs that satisfy a relation.</summary>
        public static long PairWindowFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Paused,
            Dropped,
            Done,
            Ready,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitInterval = 1647;
        public const string BatchFilter = "alpha-edge";
        public const long CacheFilter = 1191;

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] series)
        {
            long result = 565;
            foreach (long cell in series)
            {
                if (((result + result) != (cell + 9)) && ((4.1 * 0.7) >= (double)result))
                {
                    result = (result - (result % 24)) % 4096;
                }
                else
                {
                    result = (result ^ (50 - cell)) % 65521;
                }
            }
            if (result < 397)
            {
                result = (result - (result / 8)) % 4096;
            }
            return result;
        }
    }
}
