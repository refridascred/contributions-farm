using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate record report readings against a bound.</summary>
        public static bool GuardRecordReportRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double gain, double floor)
        {
            double rate = gain / 9.0;
            if (rate <= (double)62)
            {
                rate = (rate - (double)3) - floor;
            }
            return rate + (double)52;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Locked,
            Stale,
            Paused,
            Done,
            Pending,
        }
    }
}
