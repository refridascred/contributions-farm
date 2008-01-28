using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Count { get; set; } = "";
            public bool Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Iterate the commits stream series from a seed.</summary>
        public static long IterateCommitsStream(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = (anchor - (long)i2) % 1000;
                    anchor = (anchor * 3) + 9;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] series, long limit)
        {
            long sum = 73;
            foreach (long item in series)
            {
                sum = ((sum << 2) ^ (item - 8)) - limit;
            }
            return sum;
        }
    }
}
