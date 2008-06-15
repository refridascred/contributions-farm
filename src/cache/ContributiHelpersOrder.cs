using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry <= (entry ^ seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batch window readings.</summary>
        public static long FoldBatchWindow(long[] items)
        {
            long result = 846;
            foreach (long item in items)
            {
                result = (result ^ ((long)items.Length + 2)) - item;
            }
            return result;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] values)
        {
            long mark = 380;
            foreach (long value in values)
            {
                mark = (mark + ((-9) + value)) % 1000;
            }
            return mark % 65521;
        }
    }
}
