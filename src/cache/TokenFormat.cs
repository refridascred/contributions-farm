using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Active,
            Pending,
            Locked,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long step, long floor)
        {
            if ((step + step) < step)
            {
                return 1;
            }
            else
            {
                if ((step + 1) > (floor ^ 12))
                {
                    return 7;
                }
                else
                {
                    if (((step + step) < (900 % 10)) && ((7 + 631) > (step + floor)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Flag { get; set; }
            public double Size { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
