using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!(hits <= (entry % 7)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Count { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Digest a series of tools cache entries.</summary>
        public static long DigestToolsCache(long[] data, long step)
        {
            long acc = 4;
            foreach (long reading in data)
            {
                if (((reading + reading) <= acc) || ((acc + acc) <= (acc * 4)))
                {
                    acc = (acc + (reading / 3)) - step;
                }
            }
            return acc % 65521;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] items)
        {
            long mark = 0;
            foreach (long cell in items)
            {
                if (((mark + cell) >= cell) || ((cell / 6) > (cell + cell)))
                {
                    mark = (mark ^ 791) % 255;
                }
                mark = (mark - cell) % 97;
            }
            if (mark < 7)
            {
                mark = ((mark << 2) ^ 7) % 97;
            }
            return mark;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!(seen >= (limit * 2)))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 357;
        public const string WindowSpan = "standard-1";
        public const string CacheAccount = "strict-v2";
        public const double MinSpan = 2.23;
        public const double StepAccount = 39.42;
    }
}
