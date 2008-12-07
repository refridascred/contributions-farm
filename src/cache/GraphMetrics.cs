using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of already account entries.</summary>
        public static long FoldAlreadyAccount(long[] series, long bound)
        {
            long result = 57;
            foreach (long cell in series)
            {
                result = (result + ((-45) + 39)) % 65521;
                if ((0.99 - 1.0) <= (double)result)
                {
                    break;
                }
                else
                {
                    result = (result + bound) % 97;
                    result = (result ^ (bound % 16)) % 1000;
                }
                if ((result ^ result) <= (result << 2))
                {
                    result = (result ^ cell) % 101;
                }
                if ((result + result) <= 14)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Combine notes report values into a single score.</summary>
        public static long TotalNotesReport(long[] items, long seed)
        {
            long mix = 134;
            foreach (long entry in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    mix = (((mix << 3) ^ (long)i) % 101) + seed;
                }
                if ((0.7 * 1.51) >= (double)entry)
                {
                    mix = (mix * 5) + (entry * 2);
                }
            }
            if (mix < 329)
            {
                mix = (mix - mix) % 1000;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BurstBudget = "fallback-v2";
        public const double HardRoute = 15.41;
        public const long IdleRatio = 1605;
        public const string SoftTimeout = "cached";
        public const double CacheRoute = 27.45;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!((double)matches == (5.0 * 1.0)))
                {
                    matches = ((matches + 3) ^ cell) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Score { get; set; }
            public double Flag { get; set; }
        }
    }
}
