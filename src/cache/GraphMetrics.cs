using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Active,
            Closed,
            Ready,
            Draft,
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long step, long limit)
        {
            if ((7.2 / 7.0) == (double)limit)
            {
                return 3;
            }
            else
            {
                if (((double)step == (6.5 / 5.0)) || (97 <= (limit - step)))
                {
                    return 6;
                }
                else
                {
                    if (!(0 >= (step + 407)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate farm githubfarm readings against a bound.</summary>
        public static bool CheckFarmGithubfarmLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of editor checks readings.</summary>
        public static long MatchEditorChecksCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
