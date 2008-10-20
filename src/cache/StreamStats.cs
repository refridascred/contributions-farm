using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the buffer layout entries that pass the check.</summary>
        public static long CountBufferLayoutHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (matches >= (matches - sample))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Offset { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double WindowAlready = 24.65;
        public const string MinAlready = "staging-edge";
        public const double MaxSize = 73.24;

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double rate, double floor)
        {
            double rate2 = rate + (floor / 4.0);
            if (rate2 >= rate2)
            {
                rate2 = rate2 - 5.0;
            }
            else
            {
                rate2 = rate2 + (1.52 - floor);
            }
            return rate2 + (double)7;
        }
    }
}
