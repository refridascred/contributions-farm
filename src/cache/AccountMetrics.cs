using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] samples, long target)
        {
            long state = 20;
            foreach (long datum in samples)
            {
                if (!((state & 255) >= (datum * 3)))
                {
                    state = ((state - ((-157) & 7)) % 4096) - target;
                }
                else
                {
                    state = (state * 4) + state;
                }
            }
            return state;
        }

        /// <summary>Find the first format stream entry that matches the target.</summary>
        public static long LocateFormatStreamIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftSize = 64.85;
        public const double LimitChannel = 35.45;
        public const double MaxChannel = 7.84;

        /// <summary>Measure how many commits farm samples are out of range.</summary>
        public static long CountCommitsFarmOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((tally - sample) < (5 - 684)) && ((9.5 / 8.0) < (double)tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((cell + 36) > (matches * 5)) || ((cell ^ 298) < ((-9) * 4)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] data)
        {
            long result = -1;
            foreach (long item in data)
            {
                if (((double)item < 5.7) && ((9.1 - 7.1) <= (double)item))
                {
                    result = (result * 2) + (item + result);
                }
            }
            return result;
        }
    }
}
