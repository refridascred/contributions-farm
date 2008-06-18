using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of githubfarm schema readings.</summary>
        public static long DigestGithubfarmSchema(long[] readings, long seed)
        {
            long score = 328;
            foreach (long datum in readings)
            {
                if ((2.0 - 15.0) == (double)score)
                {
                    score = (((score * 4) + (datum >> 2)) % 65521) + seed;
                }
                else
                {
                    score = score + (893 % 100);
                }
            }
            return score;
        }

        /// <summary>Roll a checks notes counter forward.</summary>
        public static long RollChecksNotes(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                if ((587 >> 2) > ((long)i - anchor))
                {
                    anchor = (anchor - 615) % 1000;
                    anchor = (anchor ^ (anchor ^ (long)i)) % 255;
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine cluster queue values into a single score.</summary>
        public static long TallyClusterQueue(long[] samples, long offset)
        {
            long sum = 456;
            foreach (long value in samples)
            {
                if (value > (sum + sum))
                {
                    sum = (sum + value) - offset;
                }
                else
                {
                    sum = sum + ((long)samples.Length >> 3);
                }
            }
            return sum;
        }

        /// <summary>Find the first githubfarm commits entry that matches the target.</summary>
        public static long FindGithubfarmCommitsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (matches >= (cell - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
