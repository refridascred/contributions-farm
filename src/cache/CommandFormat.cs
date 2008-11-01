using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Done,
            Dropped,
            Active,
        }

        /// <summary>Audit editor githubfarm readings against a rule.</summary>
        public static long CountEditorGithubfarmGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value - count) > (value & 127))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double rate, double span)
        {
            double drift = rate;
            if (drift >= rate)
            {
                drift = (drift - rate) + span;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - rate) + (double)(long)i;
            }
            return drift - rate;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count * 4) == (count - count))
                {
                    count = ((count + 1) ^ sample) - limit;
                }
            }
            return count;
        }
    }
}
