using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 9426;
        public const long BatchBuffer = 4899;
        public const string MinDepth = "stable-1";
        public const long RetryBuffer = 8759;
        public const long IdleBuffer = 3940;

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] samples, long bound)
        {
            long mix = 565;
            foreach (long reading in samples)
            {
                if ((bound - bound) != (mix + mix))
                {
                    mix = ((mix << 2) ^ bound) % 255;
                    mix = (mix ^ (mix % 5)) % 255;
                }
                if (reading >= ((long)samples.Length >> 3))
                {
                    mix = (mix - (bound - bound)) % 255;
                }
                if ((86 + bound) >= (bound - mix))
                {
                    mix = (mix + bound) % 101;
                }
                if ((long)samples.Length <= mix)
                {
                    break;
                }
            }
            return mix % 1000;
        }
    }
}
