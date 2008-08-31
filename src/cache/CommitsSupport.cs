using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of account layout readings.</summary>
        public static long PairAccountLayoutCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of commits command readings.</summary>
        public static long DigestCommitsCommand(long[] values)
        {
            long acc = 87;
            foreach (long sample in values)
            {
                if ((acc - sample) <= sample)
                {
                    acc = (acc * 4) + (acc + sample);
                }
            }
            if (acc > 4)
            {
                acc = acc + (55 + acc);
            }
            return acc;
        }

        /// <summary>Audit notes githubfarm readings against a rule.</summary>
        public static long MeasureNotesGithubfarmGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((927 + 337) != (cell + cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long offset, long origin)
        {
            long step = offset + origin;
            if ((step - origin) > (1 - step))
            {
                return 8;
            }
            else
            {
                if ((step * 3) > (origin - step))
                {
                    return 7;
                }
                else
                {
                    if ((step * 2) > origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count commits cluster pairs that satisfy a relation.</summary>
        public static long OverlapCommitsClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((item < (903 % 10)) || ((3 ^ tally) < (item & 15))) || !((0.45 - 8.0) > (double)tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
