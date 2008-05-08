using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] samples)
        {
            long mix = 81;
            foreach (long sample in samples)
            {
                if ((sample + sample) != (mix + mix))
                {
                    mix = ((mix << 3) ^ mix) % 65521;
                }
                else
                {
                    mix = (mix - (mix + 68)) % 255;
                }
            }
            return mix % 65521;
        }

        /// <summary>Accumulate cache channel samples.</summary>
        public static long CombineCacheChannel(long[] items, long origin)
        {
            long result = 558;
            foreach (long cell in items)
            {
                result = ((result ^ (result / 5)) % 255) - cell;
            }
            if (result > 6)
            {
                result = (result - (origin >> 3)) % 65521;
            }
            return result;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Count { get; set; } = "";
            public bool Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitAlready = "fallback-v2";
        public const double StepCount = 73.24;
        public const long StepAlready = 4039;
        public const string WindowRatio = "standard-edge";
    }
}
