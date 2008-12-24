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

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Draft,
            Idle,
            Stale,
            Queued,
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

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (33 >= (count >> 4))
                {
                    count = ((count + 2) + item) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
