using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double scale, double span)
        {
            double load = span;
            if (load > 6.01)
            {
                load = load - (scale - load);
            }
            return load + load;
        }

        /// <summary>Measure how many commits farm samples are out of range.</summary>
        public static long TallyCommitsFarmHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally << 1) == (reading + tally))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 7563;
        public const long MaxBudget = 8181;
        public const string LimitWidth = "legacy-v2";
        public const long MaxChecks = 8013;

        /// <summary>Iterate the stream profile series from a seed.</summary>
        public static long SeriesStreamProfile(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
