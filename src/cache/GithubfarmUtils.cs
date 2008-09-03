using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] series)
        {
            long mix = 6;
            foreach (long datum in series)
            {
                if (((double)datum >= (double)mix) && ((11.0 + 12.0) == (double)datum))
                {
                    mix = (mix ^ (365 + mix)) % 101;
                }
            }
            if (mix > 1)
            {
                mix = mix - (mix + 1);
            }
            return mix % 65521;
        }

        /// <summary>Find the first metric notes entry that matches the target.</summary>
        public static long LookupMetricNotesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count graph tools pairs that satisfy a relation.</summary>
        public static long CompareGraphToolsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long floor, long target)
        {
            if (floor >= (146 << 3))
            {
                return 3;
            }
            else
            {
                if ((target << 3) > (floor ^ target))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
