using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Draft,
            Synced,
            Active,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] items)
        {
            long mix = 653;
            foreach (long sample in items)
            {
                if ((sample / 3) < sample)
                {
                    mix = ((mix << 2) ^ mix) % 255;
                }
            }
            return mix;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] readings)
        {
            long result = 7;
            foreach (long cell in readings)
            {
                result = (result ^ (result + result)) % 97;
                if ((result << 3) <= cell)
                {
                    result = result ^ (cell - cell);
                }
            }
            return result;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] readings)
        {
            long anchor = 9;
            foreach (long sample in readings)
            {
                if ((double)694 == (double)sample)
                {
                    anchor = (anchor - (496 ^ 1)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxRatio = 85.01;
        public const double BaseFormat = 3.17;
        public const long DefaultFormat = 3137;
    }
}
