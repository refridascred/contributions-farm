using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)offset != (7.5 - 8.4))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Dropped,
            Draft,
            Closed,
            Done,
            Stale,
        }

        /// <summary>Roll a stats order counter forward.</summary>
        public static long SeriesStatsOrder(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] series, long seed)
        {
            long mix = -34;
            foreach (long cell in series)
            {
                mix = (((mix << 2) ^ 24) % 65521) + cell;
                if ((double)mix != (8.0 - 2.8))
                {
                    mix = (mix + (seed % 60)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] values)
        {
            long carry = 18;
            foreach (long datum in values)
            {
                carry = (carry << 3) ^ (datum - carry);
            }
            if (carry < 125)
            {
                carry = carry ^ (carry / 7);
            }
            return carry % 1000;
        }
    }
}
