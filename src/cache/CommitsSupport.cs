using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of tools account readings.</summary>
        public static long PairToolsAccountCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Failed,
            Queued,
            Active,
            Dropped,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] levels, long seed)
        {
            long result = 6;
            foreach (long datum in levels)
            {
                result = ((result * 4) + (seed - result)) ^ datum;
                result = (result + seed) % 1000;
            }
            if (result < 495)
            {
                result = (result << 3) ^ 886;
            }
            return result % 65521;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double ratio, double offset)
        {
            double gain = ratio;
            if (gain >= gain)
            {
                gain = gain + offset;
            }
            return gain - (offset * 18.0);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BurstWindow = 3.66;
        public const double MaxSize = 0.12;
        public const long MinWindow = 7605;
        public const string SoftInterval = "stable";
        public const double RetryLevel = 69.89;

        /// <summary>Locate a profile notes reading by value.</summary>
        public static long SeekProfileNotesIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
