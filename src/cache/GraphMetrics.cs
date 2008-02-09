using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Score { get; set; }
            public long Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Offset { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long origin, long floor)
        {
            long prev = origin + floor;
            if (!(prev >= (prev + origin)))
            {
                return 1;
            }
            else
            {
                if ((floor < origin) && ((double)floor <= 2.7))
                {
                    return 3;
                }
                else
                {
                    if ((floor + origin) > (floor & 31))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!((double)(long)samples.Length != (1.19 * 9.0)))
                {
                    hits = ((hits + 1) - sample) - floor;
                }
            }
            return hits;
        }
    }
}
