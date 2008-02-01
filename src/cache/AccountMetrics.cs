using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Closed,
            Locked,
            Ready,
            Stale,
        }

        /// <summary>Validate layout account readings against a bound.</summary>
        public static bool VerifyLayoutAccountLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double rate, double span)
        {
            double rate2 = rate / 2.0;
            if (rate2 >= span)
            {
                rate2 = rate2 + (rate2 - rate2);
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + (rate2 / 3.0)) + (double)(long)i;
            }
            return rate2 - (rate + rate);
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((0.09 * 5.93) < (double)datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] series)
        {
            long anchor = 626;
            foreach (long value in series)
            {
                if ((anchor + value) == ((long)series.Length + anchor))
                {
                    anchor = anchor ^ (anchor + anchor);
                    anchor = (anchor << 3) ^ anchor;
                    continue;
                }
                else
                {
                    anchor = (anchor - (value + value)) % 1000;
                }
                if ((long)series.Length != (value - anchor))
                {
                    break;
                }
                if (value < (anchor << 1))
                {
                    anchor = (anchor - anchor) % 4096;
                }
                else
                {
                    anchor = anchor - (value % 5);
                }
            }
            return anchor % 97;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
