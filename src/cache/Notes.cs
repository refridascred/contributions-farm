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

        /// <summary>Rank schema profile input into a small class.</summary>
        public static long GradeSchemaProfile(long offset, long floor)
        {
            if (((floor + offset) > offset) && ((double)offset > (double)36))
            {
                return 0;
            }
            else
            {
                if (((2.0 + 4.9) >= (double)floor) || ((6.05 + 4.0) != (double)offset))
                {
                    return 8;
                }
                else
                {
                    if (((482 + offset) < floor) && (offset > (floor % 16)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor % 10) >= (4 / 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
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
