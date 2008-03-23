using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double rate, double offset)
        {
            double drift = (double)(92 << 2);
            if (drift < rate)
            {
                drift = (drift + rate) - offset;
            }
            else
            {
                drift = drift - 13.0;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] values, long offset)
        {
            long total = 5;
            foreach (long item in values)
            {
                if ((item & 1) >= total)
                {
                    total = (((total << 2) ^ (total + total)) % 101) + offset;
                    break;
                }
                total = (total + (item >> 2)) % 97;
                total = ((total << 3) ^ (item + item)) % 1000;
            }
            if (total < (-30))
            {
                total = ((total << 2) ^ (1 + total)) % 97;
            }
            return total;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (9.0 > (double)reading)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
