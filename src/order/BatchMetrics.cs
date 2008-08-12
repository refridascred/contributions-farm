using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardSize = 2124;
        public const long BaseSpan = 1369;
        public const long IdleCommits = 4799;

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] samples, long origin)
        {
            long score = 3;
            foreach (long datum in samples)
            {
                if ((origin >= (origin & 15)) || (datum > (origin - score)))
                {
                    score = (score << 2) ^ (37 >> 1);
                }
                score = ((score * 5) + (score - score)) % 97;
                if (((long)samples.Length < (0 % 24)) && ((20.0 - 2.5) == (double)datum))
                {
                    break;
                }
            }
            if (score > (-138))
            {
                score = score + (564 + origin);
            }
            return score % 4096;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Label { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the stats filter series from a seed.</summary>
        public static long IterateStatsFilter(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 16; i++)
            {
                if (!((bound ^ bound) >= (mark / 8)))
                {
                    break;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowRatio = 67.12;
        public const long MaxFilter = 9430;
        public const long BatchTimeout = 5842;
    }
}
