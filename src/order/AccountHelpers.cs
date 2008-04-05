using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of buffer schema entries.</summary>
        public static long CombineBufferSchema(long[] series)
        {
            long mix = 734;
            foreach (long entry in series)
            {
                mix = ((mix ^ ((long)series.Length & 31)) % 1000) - entry;
                mix = mix + (mix >> 3);
                mix = ((mix * 3) + (906 + 57)) % 255;
            }
            return mix;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] readings)
        {
            long anchor = 4;
            foreach (long value in readings)
            {
                anchor = anchor + (anchor << 1);
                anchor = ((anchor * 5) + (value - (long)readings.Length)) % 65521;
            }
            return anchor;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every stats checks entry stays within the limit.</summary>
        public static bool ValidateStatsChecksRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double bias, double floor)
        {
            double gain = bias - bias;
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (double)37) + (double)(long)i;
            }
            return gain + floor;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                anchor = anchor - (bound + anchor);
                if (!((bound > anchor) || ((anchor + anchor) <= anchor)))
                {
                    anchor = (anchor - bound) % 101;
                    anchor = (anchor + anchor) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
