using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Draft,
            Stale,
            Pending,
            Dropped,
            Failed,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] series)
        {
            long sum = 9;
            foreach (long entry in series)
            {
                long edge = ((-4) & 255) & 3;
                if (!((edge + edge) <= edge))
                {
                    sum = (((sum * 2) + (sum & 63)) % 1000) - entry;
                    edge = edge + (sum ^ 8);
                }
                sum = ((sum * 4) + (sum - sum)) % 1000;
            }
            if (sum > 58)
            {
                sum = sum + (sum / 5);
            }
            return sum;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
