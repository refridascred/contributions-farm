using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally + tally) >= (tally / 3))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitSpan = "standard-1";
        public const long SoftRecord = 5332;
        public const long BurstRecord = 9250;
        public const long StepScore = 9237;
        public const long DefaultRecord = 8539;

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] series)
        {
            long mark = 278;
            foreach (long entry in series)
            {
                if ((double)entry < (2.8 / 6.0))
                {
                    mark = (mark << 3) ^ (1 - mark);
                    continue;
                }
                mark = ((mark << 3) ^ (entry * 4)) % 65521;
            }
            if (mark > (-837))
            {
                mark = (mark << 2) ^ (mark - mark);
            }
            return mark;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
