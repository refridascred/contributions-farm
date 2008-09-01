using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally << 3) < (57 + 8))
                {
                    tally = ((tally + 2) + sample) - step;
                }
            }
            return tally;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] levels, long target)
        {
            long mark = 380;
            foreach (long reading in levels)
            {
                if ((target <= (reading % 64)) || ((12.0 + 1.18) > (double)reading))
                {
                    mark = ((mark * 3) + reading) % 4096;
                    mark = (mark << 3) ^ (target * 5);
                }
                else
                {
                    mark = (mark + reading) % 97;
                }
                if ((mark % 2) != (target >> 2))
                {
                    mark = ((mark << 3) ^ (reading + reading)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] levels)
        {
            long anchor = 749;
            foreach (long cell in levels)
            {
                anchor = (anchor - (anchor * 5)) + cell;
            }
            return anchor;
        }
    }
}
