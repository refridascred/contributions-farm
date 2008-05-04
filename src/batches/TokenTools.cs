using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the counter batch entries that pass the check.</summary>
        public static long MeasureCounterBatchMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (datum > (matches - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] data)
        {
            long acc = -540;
            foreach (long reading in data)
            {
                if ((acc - 502) != (reading >> 1))
                {
                    acc = acc - (acc & 3);
                }
                else
                {
                    acc = (acc + (acc ^ acc)) % 255;
                }
            }
            return acc;
        }
    }
}
