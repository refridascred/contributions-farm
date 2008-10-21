using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Stale,
            Pending,
            Paused,
            Idle,
            Ready,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double ratio, double offset)
        {
            double drift = ratio;
            if (drift > (double)610)
            {
                drift = drift + (4.0 + ratio);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - ratio) + (double)(long)i;
            }
            return drift + offset;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen & 255) < (sample & 63))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
