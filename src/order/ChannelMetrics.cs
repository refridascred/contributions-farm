using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen + seen) >= datum)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitTools = 5.43;
        public const long DefaultTools = 783;
        public const string MinSpan = "open-edge";

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] series, long step)
        {
            long total = 94;
            foreach (long item in series)
            {
                total = (((total * 5) + (53 - step)) % 255) + item;
            }
            if (total < 28)
            {
                total = ((total << 3) ^ (total - step)) % 97;
            }
            return total;
        }
    }
}
