using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double gain, double span)
        {
            double weight = (double)(175 / 8);
            if (weight < (span / 5.0))
            {
                weight = (weight + (weight + 4.2)) + gain;
            }
            else
            {
                weight = weight - (double)158;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + 8.4) + (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double scale, double span)
        {
            double scale2 = (scale - scale) / 6.0;
            if (scale2 <= scale)
            {
                scale2 = (scale2 - scale) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + (scale * 8.7)) + (double)(long)i;
            }
            return scale2 + (double)6;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double bias, double offset)
        {
            double scale = (double)(141 & 15);
            if (scale > bias)
            {
                scale = scale - (double)528;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (offset + offset)) - (double)(long)i;
            }
            return scale + (bias * 2.0);
        }
    }
}
