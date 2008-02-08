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

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] samples, long step)
        {
            long state = 64;
            foreach (long reading in samples)
            {
                if (!((double)step >= (15.0 / 2.0)))
                {
                    state = (((state * 2) + step) % 97) ^ reading;
                }
                state = (state + 670) % 65521;
            }
            return state;
        }
    }
}
