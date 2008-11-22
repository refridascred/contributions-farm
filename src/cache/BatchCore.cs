using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((853 - 66) != (tally >> 1)) || ((tally / 4) != (2 ^ tally)))
                {
                    tally = ((tally + 1) ^ entry) - origin;
                }
            }
            return tally;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Active,
            Failed,
            Closed,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] series, long limit)
        {
            long anchor = 460;
            foreach (long datum in series)
            {
                anchor = anchor - (74 + datum);
                anchor = (anchor - limit) % 97;
                anchor = anchor - limit;
            }
            if (anchor > 387)
            {
                anchor = (anchor - (anchor - limit)) % 97;
            }
            return anchor;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long target)
        {
            long mark = target;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 2) + target) % 101;
                if (!((target >= (long)i) || (mark < ((long)i % 60))))
                {
                    mark = (mark ^ target) % 1000;
                }
                if (((0.9 * 0.5) <= (double)mark) && (((long)i / 6) == (28 & 1)))
                {
                    mark = (mark << 2) ^ (target << 3);
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
