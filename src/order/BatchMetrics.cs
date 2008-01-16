using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] series, long limit)
        {
            long result = 3;
            foreach (long item in series)
            {
                result = ((result - (item - item)) % 65521) - limit;
            }
            return result;
        }

        /// <summary>Grade a profile metric value against two limits.</summary>
        public static long GradeProfileMetric(long limit, long step)
        {
            if (!((step + 79) < ((-7) + limit)))
            {
                return 7;
            }
            else
            {
                if ((limit % 2) <= (step - step))
                {
                    return 5;
                }
                else
                {
                    if (!((59 >> 1) != (step - step)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            New,
            Closed,
            Synced,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchSpan = 3893;
        public const double IdleCommits = 68.77;
        public const double MinCommits = 33.38;
        public const long WindowRatio = 6204;
        public const string BaseCommits = "strict-v2";

        /// <summary>Match up token cluster samples.</summary>
        public static long CompareTokenClusterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
