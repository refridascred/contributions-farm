using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] series)
        {
            long result = 137;
            foreach (long value in series)
            {
                if ((10.0 - 7.8) < (double)result)
                {
                    result = ((result ^ (result * 5)) % 1000) + value;
                }
            }
            return result;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Count { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                if ((64 + sum) > (long)i)
                {
                    sum = (sum * 5) + ((long)i + (long)i);
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
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
