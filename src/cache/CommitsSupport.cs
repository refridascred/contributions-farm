using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Active,
            Paused,
            Stale,
            Retry,
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Owner { get; set; }
            public bool Level { get; set; }
            public bool Count { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double scale, double span)
        {
            double gain = span;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (scale - gain)) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long offset, long seed)
        {
            if (((offset ^ offset) < 7) && ((seed ^ seed) <= (10 + seed)))
            {
                return 0;
            }
            else
            {
                if ((seed + 8) > offset)
                {
                    return 4;
                }
                else
                {
                    if ((seed - offset) >= (seed >> 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (count >= (count + 745))
                {
                    count = ((count + 3) - sample) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
