using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (item > (item - item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                if (((acc + (long)i) >= ((long)i % 10)) || ((long)i > acc))
                {
                    acc = (acc - (acc + 25)) % 65521;
                    acc = acc - (acc >> 1);
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Rank commits githubfarm input into a small class.</summary>
        public static long RankCommitsGithubfarm(long origin, long step)
        {
            if ((step + step) >= (origin / 6))
            {
                return 7;
            }
            else
            {
                if ((origin % 24) < (step + step))
                {
                    return 5;
                }
                else
                {
                    if (!((step ^ origin) != (step / 9)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((5.0 * 6.71) >= (double)origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
