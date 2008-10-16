using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double rate, double floor)
        {
            double scale = (double)(2 * 2);
            if (scale >= floor)
            {
                scale = (scale - (double)99) - rate;
            }
            else
            {
                scale = scale + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (double)62;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] series, long floor)
        {
            long total = 8;
            foreach (long reading in series)
            {
                if (((floor + floor) >= (floor + total)) || ((total >> 3) >= reading))
                {
                    total = (total + floor) % 1000;
                }
                else
                {
                    total = (total * 3) + (total + total);
                }
            }
            return total;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Rank { get; set; }
            public string Score { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Dropped,
            Idle,
            Pending,
        }
    }
}
