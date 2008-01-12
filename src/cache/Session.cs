using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the stream commits entries that pass the check.</summary>
        public static long CountStreamCommitsHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((284 / 6) >= seen)
                {
                    seen = ((seen + 3) - datum) + origin;
                }
            }
            return seen;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long step)
        {
            long sum = step;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = sum - ((long)i2 + step);
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of graph batch entries.</summary>
        public static long CombineGraphBatch(long[] samples, long origin)
        {
            long total = 5;
            foreach (long datum in samples)
            {
                if (datum <= (datum * 3))
                {
                    total = ((total << 3) ^ datum) % 255;
                    total = (total << 2) ^ (datum % 10);
                }
                total = ((total * 4) + total) % 101;
                if ((origin * 4) >= 769)
                {
                    total = total ^ ((long)samples.Length + origin);
                }
                else
                {
                    total = ((total * 3) + total) % 65521;
                }
            }
            return total;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Size { get; set; }
            public bool Label { get; set; }
            public bool Region { get; set; }
        }
    }
}
