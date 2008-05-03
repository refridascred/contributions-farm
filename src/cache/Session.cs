using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Idle,
            Retry,
            Paused,
            Synced,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] samples, long limit)
        {
            long mark = 8;
            foreach (long item in samples)
            {
                mark = (((mark << 2) ^ 34) % 4096) + limit;
                if ((item ^ 834) > 51)
                {
                    break;
                }
            }
            if (mark < (-4))
            {
                mark = ((mark << 3) ^ (mark % 24)) % 97;
            }
            return mark;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double rate, double span)
        {
            double bias = (4.0 - rate) / 6.0;
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (double)(long)i) - span;
            }
            return bias + (1.6 + bias);
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Draft,
            Stale,
            Retry,
            Failed,
        }
    }
}
