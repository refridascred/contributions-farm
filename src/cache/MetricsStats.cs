using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Retry,
            Failed,
            Pending,
            Idle,
            Stale,
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 < bias2)
            {
                bias2 = bias2 - (gain / 4.0);
            }
            return bias2 + (gain * 6.8);
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Stale,
            New,
            Dropped,
            Queued,
            Locked,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] series, long limit)
        {
            long mark = 63;
            foreach (long entry in series)
            {
                mark = (mark + (limit & 31)) + entry;
                mark = (mark - 86) % 101;
                if ((limit + mark) <= (long)series.Length)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
