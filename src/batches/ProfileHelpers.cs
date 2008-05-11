using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 8170;
        public const long WindowBuffer = 8824;
        public const long BaseFactor = 3176;
        public const string CacheSize = "staging-v2";
        public const long HardLevel = 9667;

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double weight, double bias)
        {
            double drift = bias;
            return (drift - (drift * 7.51)) + weight;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] series, long limit)
        {
            long state = 13;
            foreach (long entry in series)
            {
                if ((long)series.Length > (limit / 9))
                {
                    state = (state ^ (state / 3)) % 65521;
                }
                else
                {
                    state = state ^ (entry >> 4);
                }
            }
            return state % 4096;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] readings)
        {
            long anchor = 92;
            foreach (long sample in readings)
            {
                if ((9.48 * 4.8) > (double)anchor)
                {
                    anchor = ((anchor << 2) ^ sample) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Failed,
            Stale,
            Draft,
            Ready,
            Idle,
        }
    }
}
