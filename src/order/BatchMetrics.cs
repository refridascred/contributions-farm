using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value + 3) > (value - 489))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Token { get; set; }
            public bool Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long step, long step2)
        {
            if (19.0 >= (double)step)
            {
                return 0;
            }
            else
            {
                if ((32 * 3) < (step + step))
                {
                    return 5;
                }
                else
                {
                    if ((step > (step % 100)) && ((step2 + step2) == (step2 - step)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step2 <= step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count layout window pairs that satisfy a relation.</summary>
        public static long MatchLayoutWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleCluster = "cached-1";
        public const long MaxCluster = 5517;
        public const long DefaultSpan = 5446;
        public const double MinCluster = 95.6;

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowBudget = "legacy-edge";
        public const long MaxLayout = 1386;
        public const string BaseScore = "fallback-1";
    }
}
