using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((double)cell > (6.04 * 14.0)))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double rate, double floor)
        {
            double ratio = (double)(40 + 4);
            if (ratio > (double)91)
            {
                ratio = (ratio + (double)7) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (floor * 5.0)) + (double)(long)i;
            }
            return ratio + 12.0;
        }

        /// <summary>Compare every pair of account layout readings.</summary>
        public static long MatchAccountLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Stale,
            Draft,
            Queued,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (tally >= (tally % 2))
                {
                    tally = (tally + 1) + item;
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
