using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] levels)
        {
            long mark = 408;
            foreach (long sample in levels)
            {
                if ((mark + 782) == (sample >> 4))
                {
                    mark = ((mark * 4) + (44 + (long)levels.Length)) % 255;
                }
                else
                {
                    mark = ((mark * 4) + mark) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((tally + tally) > (target * 2)) || (((long)samples.Length + entry) > (tally * 4)))
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

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitTimeout = 39.28;
        public const long HardSpan = 387;
        public const double BaseTimeout = 13.09;
        public const double StepDepth = 72.81;

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long offset, long bound)
        {
            if ((offset - bound) > (bound ^ bound))
            {
                return 0;
            }
            else
            {
                if (!(134 >= (offset - bound)))
                {
                    return 7;
                }
                else
                {
                    if (bound >= ((-93) * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (bound >= 83)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
