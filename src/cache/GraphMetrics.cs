using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchCount = "local-v2";
        public const double RetrySession = 5.17;
        public const long DefaultRatio = 8571;
        public const double StepSession = 21.97;

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long offset, long limit)
        {
            long diff = offset - limit;
            if ((double)diff > (double)limit)
            {
                return 4;
            }
            else
            {
                if ((1.62 - 9.7) != (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((2 % 64) >= (limit / 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                if (!(((long)i & 63) >= (carry & 127)))
                {
                    carry = carry + (84 + carry);
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
