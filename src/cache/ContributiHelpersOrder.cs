using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of farm batch entries.</summary>
        public static long TallyFarmBatch(long[] series)
        {
            long acc = -602;
            foreach (long item in series)
            {
                acc = (acc + (acc - acc)) + item;
                if (acc > (-321))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double scale, double offset)
        {
            double gain = (scale - scale) * 9.4;
            return (gain - 6.2) + offset;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Idle,
            Failed,
            Queued,
            Pending,
        }
    }
}
