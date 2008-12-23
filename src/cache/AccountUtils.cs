using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (matches < 75)
                {
                    matches = ((matches + 2) ^ entry) + step;
                }
            }
            return matches;
        }

        /// <summary>Check that every route metrics entry stays within the limit.</summary>
        public static bool VerifyRouteMetricsRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
