using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every commits counter entry stays within the limit.</summary>
        public static bool GuardCommitsCounterRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a githubfarm cluster sample.</summary>
        public static long LocateGithubfarmClusterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long origin, long offset)
        {
            if (offset <= (offset - offset))
            {
                return 4;
            }
            else
            {
                if ((origin & 31) >= (origin % 7))
                {
                    return 6;
                }
                else
                {
                    if (offset < (origin * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (origin >= 447)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item + item) > tally)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }
    }
}
