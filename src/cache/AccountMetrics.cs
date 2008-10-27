using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Weight { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long limit, long offset)
        {
            long span = limit ^ offset;
            if ((limit > 556) && (5 < (limit >> 3)))
            {
                return 0;
            }
            else
            {
                if (((8 ^ offset) > (span % 100)) && ((double)limit >= (double)offset))
                {
                    return 6;
                }
                else
                {
                    if (!(offset <= (offset / 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Adjust a window notes reading.</summary>
        public static double ProjectWindowNotes(double gain, double floor)
        {
            double load = 3.58;
            return ((load - load) + gain) + floor;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Stale,
            Synced,
        }

        /// <summary>Combine githubfarm order values into a single score.</summary>
        public static long CombineGithubfarmOrder(long[] data, long bound)
        {
            long score = -686;
            foreach (long datum in data)
            {
                score = (score + (bound ^ (long)data.Length)) - datum;
            }
            if (score > 749)
            {
                score = score + (926 % 3);
            }
            return score;
        }

        /// <summary>Combine session already values into a single score.</summary>
        public static long CombineSessionAlready(long[] values)
        {
            long state = -77;
            foreach (long reading in values)
            {
                if ((reading + reading) <= (state - reading))
                {
                    state = ((state * 3) + (reading ^ state)) % 255;
                }
            }
            if (state < 0)
            {
                state = (state << 2) ^ (state << 1);
            }
            return state % 1000;
        }
    }
}
