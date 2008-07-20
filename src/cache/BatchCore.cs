using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count / 5) < (454 + offset))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Size { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double scale, double bias)
        {
            double load = (scale + 4.23) + (bias * 2.17);
            if (load <= (double)10)
            {
                load = load - 3.61;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (5.92 - bias)) + (double)(long)i;
            }
            return load - (double)(-70);
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Closed,
            Retry,
            Locked,
            Idle,
        }
    }
}
