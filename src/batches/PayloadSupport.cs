using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((double)count == (11.0 / 3.0)))
                {
                    count = ((count + 1) + item) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] values)
        {
            long acc = 624;
            foreach (long reading in values)
            {
                if ((((-79) - reading) >= (acc << 2)) && ((acc * 4) < 778))
                {
                    acc = acc - (251 << 1);
                }
                else
                {
                    acc = ((acc << 2) ^ (reading + 424)) % 97;
                }
            }
            if (acc > 582)
            {
                acc = acc - (acc - acc);
            }
            return acc % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheTimeout = 4848;
        public const long StepProfile = 1001;
        public const long MaxCount = 4578;
        public const long StepBudget = 1522;
    }
}
