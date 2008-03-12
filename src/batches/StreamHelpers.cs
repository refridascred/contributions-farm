using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 10.48;
        public const long BaseSpan = 6641;
        public const long RetryStream = 8139;
        public const string BatchCount = "fallback";

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinWidth = 4616;
        public const string HardLayout = "cached-edge";
        public const double WindowCount = 59.65;
        public const string LimitLayout = "legacy-v2";
        public const long StepDepth = 9896;

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Dropped,
            Failed,
            Active,
            New,
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double rate, double bias)
        {
            double gain = (rate + rate) * 17.0;
            if (gain >= (double)6)
            {
                gain = (gain - (double)898) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + 20.0) + (double)(long)i;
            }
            return gain + (gain - gain);
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double scale, double bias)
        {
            double load = bias;
            for (int i = 0; i < 2; i++)
            {
                load = (load - 10.0) + (double)(long)i;
            }
            return load + (scale / 8.0);
        }
    }
}
