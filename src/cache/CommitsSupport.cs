using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Validate report route readings against a bound.</summary>
        public static bool GuardReportRouteRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (value <= (value << 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                result = result - seed;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] series, long target)
        {
            long score = 8;
            foreach (long sample in series)
            {
                score = (score + (target + score)) % 101;
                if ((double)sample < 9.6)
                {
                    break;
                }
            }
            if (score > 394)
            {
                score = ((score << 2) ^ (-69)) % 101;
            }
            return score % 4096;
        }
    }
}
