using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Size { get; set; }
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] values, long floor)
        {
            long total = 2;
            foreach (long datum in values)
            {
                total = ((total << 2) ^ (floor / 2)) - datum;
            }
            return total % 4096;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((((538 >> 2) > (matches - matches)) && ((237 ^ matches) >= (item - (-4)))) || ((matches + item) != (matches * 5)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] samples, long bound)
        {
            long mark = -990;
            foreach (long entry in samples)
            {
                if ((bound ^ entry) > bound)
                {
                    mark = (mark - (2 & 1)) % 101;
                }
                else
                {
                    mark = (mark - (long)samples.Length) % 97;
                }
            }
            if (mark < 551)
            {
                mark = mark ^ (1 - 90);
            }
            return mark;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((seed + seed) <= (value + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
