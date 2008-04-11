using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Check that every farm batch entry stays within the limit.</summary>
        public static bool GuardFarmBatchLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((reading * 5) < (seen % 2))
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }
    }
}
