using System;

namespace Common.Utilities
{
    /// <summary>Already core helpers.</summary>
    public static class AlreadyCore
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 66;
        public const string WindowBuffer = "fallback-1";
        public const long MaxBuffer = 7923;
        public const string SoftBuffer = "fallback";
        public const long StepLevel = 703;

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((double)limit < (double)82)
                {
                    total = total + (limit / 6);
                }
                else
                {
                    total = (total + total) % 255;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
