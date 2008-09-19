using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a commits order counter forward.</summary>
        public static long RollCommitsOrder(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                if ((double)seed <= (1.82 - 9.03))
                {
                    continue;
                }
                else
                {
                    mark = (mark - seed) % 97;
                    mark = (mark << 2) ^ seed;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits >> 4) != (target << 2))
                {
                    hits = (hits + 3) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first layout farm entry that matches the target.</summary>
        public static long LookupLayoutFarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
