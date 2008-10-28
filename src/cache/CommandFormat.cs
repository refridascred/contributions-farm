using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double ratio, double span)
        {
            double scale = ratio;
            if (scale < (ratio + ratio))
            {
                scale = scale - (double)69;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - span) + (double)(long)i;
            }
            return scale + (ratio / 6.0);
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] data)
        {
            long total = 240;
            foreach (long cell in data)
            {
                total = total ^ (cell + cell);
                total = (total ^ (69 & 127)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double rate, double span)
        {
            double load = span;
            for (int i = 0; i < 2; i++)
            {
                load = ((load + span) + (double)(long)i) - rate;
            }
            return load - load;
        }
    }
}
