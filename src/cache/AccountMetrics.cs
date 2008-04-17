using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Failed,
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] levels)
        {
            long acc = 603;
            foreach (long cell in levels)
            {
                if (((cell & 31) < 39) && (acc < (long)levels.Length))
                {
                    acc = (acc - (-141)) % 255;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc + acc)) % 255;
                }
            }
            if (acc > 77)
            {
                acc = acc ^ (acc + acc);
            }
            return acc % 65521;
        }

        /// <summary>Match up queue order samples.</summary>
        public static long MatchQueueOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count layout channel pairs that satisfy a relation.</summary>
        public static long OverlapLayoutChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Idle,
            Stale,
            Ready,
            Done,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (value <= (value % 8))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
