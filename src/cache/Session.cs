using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double rate, double offset)
        {
            double load = (double)92 * 5.22;
            if (load > (load + load))
            {
                load = load - (load + 9.81);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - rate) + (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Queued,
            Locked,
            New,
            Dropped,
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Active,
            Locked,
            Ready,
            Dropped,
            Paused,
        }

        /// <summary>Audit entry format readings against a rule.</summary>
        public static long CountEntryFormatGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (offset >= (datum - offset))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
