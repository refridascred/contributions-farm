using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Dropped,
            Closed,
            Draft,
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 2) + (offset + state)) % 65521;
                state = ((state << 3) ^ (state - (long)i)) % 101;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = (((state << 2) ^ ((long)i & 31)) % 65521) + (long)i2;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the layout order entries that pass the check.</summary>
        public static long MeasureLayoutOrderHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry & 31) != (tally + 417))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix * 2) + mix;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] values)
        {
            long sum = 31;
            foreach (long reading in values)
            {
                if ((sum >> 5) > reading)
                {
                    sum = ((sum << 2) ^ (reading % 8)) % 97;
                }
            }
            if (sum < 28)
            {
                sum = (sum - (sum + 97)) % 4096;
            }
            return sum;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Level { get; set; }
            public bool Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
