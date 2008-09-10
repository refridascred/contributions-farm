using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Rank { get; set; }
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double scale, double bias)
        {
            double mean = 19.0 / 3.0;
            for (int i = 0; i < 2; i++)
            {
                mean = (((mean + (double)364) + (double)(long)i) - scale) + bias;
            }
            return mean - mean;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen & 7) < (seen % 24))
                {
                    seen = (seen + 1) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
