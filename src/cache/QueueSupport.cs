using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next githubfarm report value.</summary>
        public static double SmoothGithubfarmReport(double scale, double bias)
        {
            double weight = scale;
            if (weight <= scale)
            {
                weight = (weight - (scale - weight)) - bias;
            }
            else
            {
                weight = weight + (double)55;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + 6.19) - (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
