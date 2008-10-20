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

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Owner { get; set; }
            public double Region { get; set; }
            public bool Rank { get; set; }
        }

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
