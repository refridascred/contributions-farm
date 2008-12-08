using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long target)
        {
            long mark = target;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = (mark ^ mark) + (long)i2;
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    mark = ((mark ^ target) % 97) - (long)i3;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit account entry readings against a rule.</summary>
        public static long MeasureAccountEntryHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!(count <= (entry << 1)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] items)
        {
            long carry = 721;
            foreach (long sample in items)
            {
                if (((carry / 6) <= 8) || ((sample % 8) > (sample - sample)))
                {
                    carry = (carry * 2) + (sample / 4);
                }
            }
            return carry;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Retry,
            Ready,
            Failed,
            New,
        }
    }
}
