using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Rank { get; set; }
            public double Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Region { get; set; }
            public double Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits + target) > (target + sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((reading % 60) != (reading + tally)) || ((reading < (tally >> 5)) && ((5.05 - 6.07) < (double)tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
