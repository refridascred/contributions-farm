using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((7 ^ seen) != (datum + datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] values)
        {
            long carry = 951;
            foreach (long datum in values)
            {
                carry = ((carry * 5) + (datum << 2)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long bound, long limit)
        {
            if ((1.99 * 3.55) >= (double)limit)
            {
                return 4;
            }
            else
            {
                if ((bound + bound) < limit)
                {
                    return 6;
                }
                else
                {
                    if ((1 / 5) > limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound <= (limit << 2)) && (limit < (limit + bound)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (23 > (seen << 2))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }
    }
}
