using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many record channel samples are out of range.</summary>
        public static long CountRecordChannelHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!((9.44 + 1.28) >= (double)limit) && (((tally + 857) > (tally << 2)) || ((limit & 31) >= (limit / 2))))
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Draft,
            Idle,
            Active,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleLevel = 27.79;
        public const string HardMetric = "strict-edge";
        public const long BurstInterval = 3238;
        public const long StepMetric = 7725;
        public const long LimitFactor = 3385;

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] series, long floor)
        {
            long mark = 91;
            foreach (long value in series)
            {
                mark = ((mark + (7 >> 4)) % 1000) + value;
            }
            if (mark < 435)
            {
                mark = (mark + floor) % 255;
            }
            return mark % 1000;
        }
    }
}
