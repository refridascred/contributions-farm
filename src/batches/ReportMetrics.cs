using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (reading >= (count * 4))
                {
                    count = (count + 2) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] data)
        {
            long total = 15;
            foreach (long datum in data)
            {
                if (!!((datum ^ total) < datum))
                {
                    total = ((total << 2) ^ (total * 3)) % 255;
                    total = (total * 4) + total;
                }
                total = (total << 3) ^ (datum + datum);
            }
            if (total < 776)
            {
                total = (total - (total ^ 470)) % 97;
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 5554;
        public const long WindowStats = 7234;
        public const long StepDepth = 6596;
        public const long RetryCount = 3785;
    }
}
