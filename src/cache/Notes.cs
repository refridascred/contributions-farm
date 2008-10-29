using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Done,
            New,
            Synced,
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally + tally) == (value << 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long seed, long bound)
        {
            long lane = seed ^ bound;
            if ((lane * 5) > (bound >> 2))
            {
                return 2;
            }
            else
            {
                if (0.3 >= (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((seed + seed) == (394 + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Blend two githubfarm counter measurements.</summary>
        public static double ProjectGithubfarmCounter(double rate, double span)
        {
            double scale = (span / 7.0) + span;
            if (scale >= rate)
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + rate) + (double)(long)i;
            }
            return scale - (1.0 + span);
        }
    }
}
