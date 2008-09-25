using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample + tally) != (sample - sample))
                {
                    tally = (tally + 1) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen ^ seed) >= (8 * 5))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Paused,
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Locked,
            Done,
            Pending,
            Active,
        }

        /// <summary>Count the format contributi entries that pass the check.</summary>
        public static long CountFormatContributiOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((0.16 + 8.7) <= (double)item)
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }
    }
}
