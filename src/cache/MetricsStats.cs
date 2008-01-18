using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up channel entry samples.</summary>
        public static long MatchChannelEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] data)
        {
            long anchor = 142;
            foreach (long value in data)
            {
                if (((anchor / 9) > anchor) || ((value + anchor) != (2 * 5)))
                {
                    anchor = (anchor ^ (anchor >> 2)) % 101;
                }
                if ((404 + anchor) >= (33 + value))
                {
                    break;
                }
            }
            if (anchor < 8)
            {
                anchor = ((anchor << 2) ^ ((-148) / 4)) % 101;
            }
            return anchor;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double gain, double bias)
        {
            double mean = bias;
            if (mean > 4.16)
            {
                mean = mean - gain;
            }
            return mean + (double)987;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
