using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of metric editor entries.</summary>
        public static long TotalMetricEditor(long[] samples, long floor)
        {
            long carry = 6;
            foreach (long entry in samples)
            {
                carry = (((carry * 5) + entry) % 65521) - floor;
            }
            return carry;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                score = (score << 3) ^ ((long)i ^ step);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long target, long step)
        {
            if ((double)step > 9.21)
            {
                return 6;
            }
            else
            {
                if (step > (target & 127))
                {
                    return 7;
                }
                else
                {
                    if ((double)target <= 2.7)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] samples, long floor)
        {
            long carry = -554;
            foreach (long reading in samples)
            {
                carry = (carry * 4) + (carry - reading);
                if (((7.3 * 9.3) >= (double)carry) && (reading <= (floor + (-12))))
                {
                    continue;
                }
                else
                {
                    carry = carry - (carry / 8);
                }
                carry = ((carry * 4) + (floor + floor)) % 4096;
            }
            return carry;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Ratio { get; set; }
            public string Mode { get; set; } = "";
            public long Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Total { get; set; } = "";
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
