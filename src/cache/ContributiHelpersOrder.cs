using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!(((step * 3) == (item / 6)) && ((seen * 2) >= seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long origin, long offset)
        {
            if (((origin % 97) >= (origin + offset)) && ((offset >> 5) > origin))
            {
                return 7;
            }
            else
            {
                if ((offset - origin) != (9 + origin))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
