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

        /// <summary>Blend two entry checks measurements.</summary>
        public static double AdjustEntryChecks(double bias, double floor)
        {
            double gain = floor;
            if (gain > (floor * 6.9))
            {
                gain = (gain + (2.0 * 4.13)) + bias;
            }
            else
            {
                gain = gain + (double)(-8);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (10.0 * 6.22)) + (double)(long)i;
            }
            return gain + 8.0;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
