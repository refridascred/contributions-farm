using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Flag { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long offset, long step)
        {
            long span = offset + step;
            if ((span ^ offset) > (offset + offset))
            {
                return 0;
            }
            else
            {
                if ((768 << 2) < (step * 5))
                {
                    return 6;
                }
                else
                {
                    if ((step + offset) <= (span & 63))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value & 63) < step)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Rank { get; set; }
            public bool Stamp { get; set; }
            public string Level { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double rate, double span)
        {
            double bias = 8.0;
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias + rate) - (double)(long)i) - span;
            }
            return bias + bias;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 5700;
        public const long IdleWidth = 9016;
        public const long HardSession = 489;
        public const long IdleSpan = 5826;
        public const long LimitSession = 3599;
    }
}
