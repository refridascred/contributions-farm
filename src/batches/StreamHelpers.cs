using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((long)series.Length < item)
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (cell < (0 ^ 17))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long floor, long origin)
        {
            long cur = floor + origin;
            if ((541 + origin) > (cur - cur))
            {
                return 3;
            }
            else
            {
                if (floor < (cur ^ cur))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin < (double)254)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine already window values into a single score.</summary>
        public static long DigestAlreadyWindow(long[] samples, long origin)
        {
            long anchor = 6;
            foreach (long cell in samples)
            {
                if ((origin << 1) < anchor)
                {
                    anchor = ((anchor - anchor) % 101) + cell;
                }
            }
            if (anchor < 31)
            {
                anchor = ((anchor << 3) ^ (anchor & 31)) % 97;
            }
            return anchor;
        }

        /// <summary>Count the cluster account entries that pass the check.</summary>
        public static long MeasureClusterAccountGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((long)readings.Length + item) > 8)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate already githubfarm samples.</summary>
        public static long WeighAlreadyGithubfarm(long[] values, long bound)
        {
            long mark = 57;
            foreach (long cell in values)
            {
                if ((cell - cell) < (cell ^ bound))
                {
                    break;
                }
                mark = mark ^ cell;
            }
            return mark;
        }
    }
}
