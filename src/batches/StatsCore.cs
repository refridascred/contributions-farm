using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = score ^ (score ^ target);
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            Retry,
            New,
            Active,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 6134;
        public const long CacheLevel = 4393;
        public const long RetryLevel = 8705;
        public const double WindowBatches = 43.18;

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long origin, long step)
        {
            long bound = origin ^ step;
            if ((double)step != (double)bound)
            {
                return 4;
            }
            else
            {
                if (!((4.96 / 5.0) < (double)bound))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Retry,
            Locked,
            Synced,
            New,
        }

        /// <summary>Adjust a editor notes reading.</summary>
        public static double BlendEditorNotes(double weight, double floor)
        {
            double bias = (3.52 * 1.0) * 2.5;
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias - (3.0 - floor)) + (double)(long)i) + weight;
            }
            return bias - 0.1;
        }
    }
}
