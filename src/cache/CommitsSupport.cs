using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] series, long seed)
        {
            long mix = 879;
            foreach (long item in series)
            {
                mix = (((mix * 5) + (864 + seed)) % 4096) ^ item;
            }
            return mix;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BurstSupport = 20.22;
        public const long SoftSize = 3278;
        public const double StepLevel = 10.06;
        public const double BaseSupport = 10.95;
        public const long HardSupport = 8896;

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            New,
            Draft,
            Stale,
            Queued,
            Dropped,
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of account cluster readings.</summary>
        public static long WeighAccountCluster(long[] levels)
        {
            long score = 9;
            foreach (long entry in levels)
            {
                if (!((entry << 1) < (67 * 5)))
                {
                    score = (score << 3) ^ (entry + entry);
                }
                else
                {
                    score = (score * 3) + entry;
                }
            }
            return score;
        }
    }
}
