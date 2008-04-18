using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Size { get; set; } = "";
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] samples, long origin)
        {
            long sum = 756;
            foreach (long item in samples)
            {
                if ((sum / 9) > (item / 4))
                {
                    sum = (((sum * 5) + ((long)samples.Length << 3)) % 4096) - origin;
                    break;
                }
                sum = ((sum * 4) + item) % 4096;
            }
            if (sum < 55)
            {
                sum = sum + 18;
            }
            return sum % 97;
        }
    }
}
