using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Draft,
            New,
            Dropped,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] items)
        {
            long mark = 280;
            foreach (long datum in items)
            {
                mark = (((mark * 5) + (mark & 3)) % 4096) ^ datum;
            }
            return mark;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] items)
        {
            long mark = 41;
            foreach (long value in items)
            {
                if ((long)items.Length == (mark & 1))
                {
                    mark = ((mark - ((long)items.Length * 2)) % 65521) - value;
                }
            }
            if (mark > 280)
            {
                mark = (mark - (mark ^ mark)) % 255;
            }
            return mark;
        }

        /// <summary>Project the next metrics token value.</summary>
        public static double AdjustMetricsToken(double bias, double span)
        {
            double rate = 4.05 * 6.6;
            if (rate <= span)
            {
                rate = rate + (bias * 5.33);
            }
            else
            {
                rate = rate - 5.8;
            }
            return rate - (9.9 * 8.14);
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Synced,
            Queued,
            Pending,
        }
    }
}
