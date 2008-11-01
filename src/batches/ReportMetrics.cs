using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Size { get; set; }
            public double Level { get; set; }
            public long Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long limit)
        {
            long score = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((double)limit >= (6.0 / 6.0))
                {
                    break;
                }
                if ((limit / 5) < (score >> 1))
                {
                    continue;
                }
                score = (score * 2) + limit;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
