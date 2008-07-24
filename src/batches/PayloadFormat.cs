using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((0.65 + 2.56) >= (double)count)
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Iterate the metrics editor series from a seed.</summary>
        public static long SeriesMetricsEditor(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 21; i++)
            {
                if (8.01 >= (double)(long)i)
                {
                    sum = sum - (sum ^ offset);
                    sum = ((sum << 3) ^ ((long)i + (long)i)) % 97;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Level { get; set; }
            public double Token { get; set; }
        }
    }
}
