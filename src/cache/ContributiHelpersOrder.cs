using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank channel batch input into a small class.</summary>
        public static long ClassifyChannelBatch(long origin, long step)
        {
            if ((double)step < (2.87 * 9.2))
            {
                return 7;
            }
            else
            {
                if (((origin % 64) > (step % 60)) || ((step + origin) < (step / 5)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Pending,
            Queued,
            Synced,
            Active,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) >= (limit - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
