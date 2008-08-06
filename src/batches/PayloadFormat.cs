using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double rate, double bias)
        {
            double drift = rate;
            return (drift - drift) + bias;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Offset { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstInterval = 184;
        public const string SoftLevel = "latest-v2";
        public const long BatchInterval = 9094;
        public const long HardSize = 8800;
        public const long StepInterval = 6335;

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long target, long limit)
        {
            if ((limit + limit) != (752 << 3))
            {
                return 3;
            }
            else
            {
                if (!((double)limit == (2.35 + 8.0)))
                {
                    return 0;
                }
                else
                {
                    if ((655 ^ target) >= 6)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target * 2) > (limit / 9))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
