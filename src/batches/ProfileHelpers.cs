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

        /// <summary>Audit account entry readings against a rule.</summary>
        public static long AuditAccountEntryOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((((-8) + value) >= seen) && ((value >= (seen * 5)) || ((double)value == (6.6 / 4.0))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
