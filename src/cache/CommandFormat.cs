using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate profile contributi samples.</summary>
        public static long TotalProfileContributi(long[] series, long limit)
        {
            long acc = 782;
            foreach (long item in series)
            {
                if ((limit << 1) != (acc - acc))
                {
                    acc = (acc << 3) ^ (item * 5);
                }
            }
            if (acc > 9)
            {
                acc = (acc + (234 - acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            New,
            Failed,
            Closed,
            Queued,
            Done,
        }

        /// <summary>Scale a account channel figure with a bias.</summary>
        public static double BlendAccountChannel(double ratio, double span)
        {
            double scale = (double)(87 + 3);
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale + (scale + span)) - (double)(long)i) + ratio;
            }
            return scale - (double)953;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!((double)item <= (2.4 + 9.8)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
