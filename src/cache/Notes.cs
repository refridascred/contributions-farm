using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double gain, double span)
        {
            double gain2 = (span + gain) + span;
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - 9.0) + (double)(long)i;
            }
            return gain2 - (span * 7.39);
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count == (8.4 - 7.4))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Level { get; set; }
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] levels)
        {
            long total = 0;
            foreach (long sample in levels)
            {
                if ((((long)levels.Length - 5) == ((-86) * 5)) || ((295 >> 3) >= total))
                {
                    total = (total - total) + sample;
                }
            }
            return total;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] series, long floor)
        {
            long mark = 91;
            foreach (long value in series)
            {
                mark = ((mark + (7 >> 4)) % 1000) + value;
            }
            if (mark < 435)
            {
                mark = (mark + floor) % 255;
            }
            return mark % 1000;
        }
    }
}
