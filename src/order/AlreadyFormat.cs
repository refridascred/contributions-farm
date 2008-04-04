using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Score { get; set; }
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Idle,
            Stale,
            New,
            Pending,
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Done,
            Stale,
            Retry,
            Idle,
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix ^ (floor + mix)) % 1000;
                mix = ((mix * 4) + (floor - floor)) % 65521;
                mix = (mix + mix) % 255;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] items)
        {
            long result = -448;
            foreach (long reading in items)
            {
                if ((reading + 20) >= (result % 2))
                {
                    result = (result + (13 & 63)) % 255;
                }
            }
            return result;
        }
    }
}
