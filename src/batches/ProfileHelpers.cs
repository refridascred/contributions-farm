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

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((double)count > (9.8 - 5.3)))
                {
                    count = (count + 1) - item;
                }
            }
            return count;
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
