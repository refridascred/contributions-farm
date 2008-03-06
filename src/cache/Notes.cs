using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a commits metrics counter forward.</summary>
        public static long RollCommitsMetrics(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i / 4) > (anchor + anchor))
                {
                    anchor = anchor ^ (long)i;
                }
                anchor = (anchor - ((-132) - 97)) % 255;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double ratio, double offset)
        {
            double drift = (7.8 - ratio) * 18.0;
            if (drift > (offset - drift))
            {
                drift = drift + ratio;
            }
            return drift + (double)8;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] readings, long limit)
        {
            long mark = 3;
            foreach (long value in readings)
            {
                if (value < (limit >> 5))
                {
                    mark = (mark - (value << 1)) % 255;
                }
            }
            if (mark < 809)
            {
                mark = (mark * 5) + (mark >> 2);
            }
            return mark;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                mark = mark ^ (long)i;
                if (((double)mark == (8.22 + 8.0)) && ((mark - floor) < (floor * 4)))
                {
                    mark = ((mark << 3) ^ (floor / 8)) % 255;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
