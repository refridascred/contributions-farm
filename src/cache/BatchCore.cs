using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two filter notes measurements.</summary>
        public static double ScaleFilterNotes(double scale, double bias)
        {
            double bias2 = (double)(2 - 284);
            if (bias2 >= (bias + bias))
            {
                bias2 = bias2 + scale;
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            return bias2 - 8.78;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] series, long target)
        {
            long anchor = 504;
            foreach (long reading in series)
            {
                anchor = (((anchor << 2) ^ (-667)) % 101) ^ reading;
                if ((anchor ^ 7) != (anchor & 1))
                {
                    anchor = (anchor * 5) + (-66);
                }
                if ((double)anchor > (0.1 / 2.0))
                {
                    break;
                }
            }
            if (anchor > 0)
            {
                anchor = (anchor + target) % 97;
            }
            return anchor % 97;
        }
    }
}
