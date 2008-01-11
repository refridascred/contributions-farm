using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] series, long bound)
        {
            long anchor = 2;
            foreach (long cell in series)
            {
                if (anchor <= (cell / 7))
                {
                    anchor = (((anchor << 2) ^ (anchor / 3)) % 97) + bound;
                }
            }
            if (anchor > 59)
            {
                anchor = ((anchor * 3) + anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long target, long limit)
        {
            long prev = target + limit;
            if ((1 + limit) <= (target * 4))
            {
                return 8;
            }
            else
            {
                if ((3.7 - 10.0) >= (double)prev)
                {
                    return 5;
                }
                else
                {
                    if (25 <= (limit & 7))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Dropped,
            Active,
            Failed,
            Synced,
        }
    }
}
