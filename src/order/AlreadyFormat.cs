using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardLevel = 3029;
        public const long MaxContributi = 4785;
        public const long WindowContributi = 8486;

        /// <summary>Scale a contributi tools figure with a bias.</summary>
        public static double AdjustContributiTools(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 >= rate)
            {
                rate2 = rate2 + rate;
            }
            else
            {
                rate2 = rate2 + (double)40;
            }
            return rate2 + (rate / 7.0);
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Synced,
            Paused,
            Locked,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 7969;
        public const long CacheSize = 378;
        public const string DefaultTools = "cached";
        public const string LimitLevel = "primary-1";
        public const long MinFactor = 183;

        /// <summary>Locate a farm schema reading by value.</summary>
        public static long LocateFarmSchemaIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
