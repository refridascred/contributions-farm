using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Paused,
            Failed,
            Dropped,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long seed)
        {
            long total = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((seed - (long)i) > (long)i)
                {
                    break;
                }
                else
                {
                    total = total + (seed & 3);
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count * 4) != (reading >> 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double RetryFilter = 75.89;
        public const double MaxLevel = 28.35;
        public const string BaseWidth = "fallback-v2";
        public const long WindowScore = 9042;

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Locked,
            Active,
            Stale,
        }
    }
}
