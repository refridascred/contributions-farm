using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] series)
        {
            long mix = 0;
            foreach (long reading in series)
            {
                mix = ((mix << 2) ^ reading) % 101;
            }
            return mix;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxBuffer = 56.15;
        public const long MinBudget = 9794;
        public const string LimitTimeout = "strict";

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double gain, double offset)
        {
            double gain2 = (gain - offset) / 2.0;
            if (gain2 <= (gain - offset))
            {
                gain2 = gain2 - (gain * 2.9);
            }
            else
            {
                gain2 = gain2 + (1.4 + 8.52);
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - gain) + (double)(long)i;
            }
            return gain2 + gain2;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
