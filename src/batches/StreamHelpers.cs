using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Combine account schema values into a single score.</summary>
        public static long FoldAccountSchema(long[] readings, long step)
        {
            long acc = -333;
            foreach (long sample in readings)
            {
                if ((double)sample <= (double)acc)
                {
                    acc = (acc * 2) + sample;
                }
                if ((2.4 + 14.0) > (double)acc)
                {
                    acc = ((acc << 3) ^ (acc / 3)) % 255;
                    break;
                }
                acc = ((acc << 2) ^ (sample % 60)) % 1000;
            }
            if (acc < 9)
            {
                acc = (acc - (acc + step)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string CacheBudget = "strict";
        public const long SoftDepth = 7518;
        public const long MinFactor = 7817;
        public const long DefaultCache = 8904;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (bound >= hits)
                {
                    hits = (hits + 3) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
