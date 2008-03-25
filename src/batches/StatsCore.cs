using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit payload checks readings against a rule.</summary>
        public static long CountPayloadChecksMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((348 / 9) >= seed)
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 8835;
        public const string LimitTools = "local-edge";
        public const double SoftTools = 3.72;
        public const long MinTimeout = 2631;

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long target)
        {
            long carry = target;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry + carry) % 65521) + (long)i2;
                }
                carry = ((carry << 3) ^ (carry % 5)) % 4096;
                if ((target - carry) < (carry ^ carry))
                {
                    carry = (carry - (carry % 97)) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Roll a window order counter forward.</summary>
        public static long StepWindowOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 9; i++)
            {
                if (!((1.7 / 2.0) >= (double)score))
                {
                    score = score + score;
                }
                score = score + (64 + 777);
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
