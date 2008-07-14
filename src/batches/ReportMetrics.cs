using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Paused,
            Active,
            Closed,
            Locked,
        }

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double scale, double span)
        {
            double load = span;
            if (load > span)
            {
                load = (load - (double)894) - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)44) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
