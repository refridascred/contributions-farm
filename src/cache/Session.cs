using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((double)reading < (2.8 * 3.0)) || ((hits - (long)readings.Length) == (reading + limit)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Synced,
            Paused,
            Closed,
            Idle,
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double rate, double span)
        {
            double load = rate;
            if (load < rate)
            {
                load = load + span;
            }
            else
            {
                load = load + (rate * 5.2);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - span) + (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Rank { get; set; }
            public long Region { get; set; }
        }
    }
}
