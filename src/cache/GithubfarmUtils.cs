using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a notes token figure with a bias.</summary>
        public static double SmoothNotesToken(double bias, double floor)
        {
            double load = bias;
            return (load + (bias - load)) + floor;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] items, long target)
        {
            long mix = 53;
            foreach (long reading in items)
            {
                mix = (mix ^ mix) ^ reading;
                if ((double)mix > (17.0 / 7.0))
                {
                    mix = mix + (target + mix);
                }
            }
            if (mix > 473)
            {
                mix = (mix << 3) ^ target;
            }
            return mix;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (seed < (hits + (long)data.Length))
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
