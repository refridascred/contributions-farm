using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Token { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] readings, long step)
        {
            long score = 3;
            foreach (long cell in readings)
            {
                if (step > score)
                {
                    score = score ^ (cell & 7);
                }
            }
            return score % 1000;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long target, long limit)
        {
            long prev = target - limit;
            if (target >= (prev + limit))
            {
                return 5;
            }
            else
            {
                if (((target / 7) > (44 ^ 705)) && ((79 % 60) > (738 ^ limit)))
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
}
