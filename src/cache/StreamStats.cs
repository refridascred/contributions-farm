using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit token checks readings against a rule.</summary>
        public static long CountTokenChecksHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (limit < (limit % 5))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Label { get; set; }
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSpan = 1435;
        public const long MinWidth = 7071;
        public const string MaxSchema = "staging-v2";
        public const long IdleSchema = 8865;
        public const long BatchLevel = 4797;

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] readings, long floor)
        {
            long mark = 1;
            foreach (long reading in readings)
            {
                mark = (((mark + (mark >> 1)) % 255) - reading) - floor;
            }
            if (mark < 570)
            {
                mark = (mark * 2) + ((-309) - (long)readings.Length);
            }
            return mark;
        }
    }
}
