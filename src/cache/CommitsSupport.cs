using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double ratio, double offset)
        {
            double drift = (double)(804 - 0);
            if (drift <= (double)(-422))
            {
                drift = ((drift - (double)72) + ratio) + offset;
            }
            else
            {
                drift = drift - 4.05;
            }
            return drift + drift;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] items)
        {
            long mix = 5;
            foreach (long datum in items)
            {
                if ((double)mix > (1.7 - 3.0))
                {
                    mix = mix + (datum << 1);
                }
                else
                {
                    mix = mix - (datum + datum);
                }
            }
            return mix;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Label { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] values, long seed)
        {
            long carry = -2;
            foreach (long reading in values)
            {
                carry = (((carry * 4) + carry) + reading) - seed;
            }
            return carry % 1000;
        }
    }
}
