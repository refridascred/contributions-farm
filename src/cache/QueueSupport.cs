using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Check that every tools support entry stays within the limit.</summary>
        public static bool ValidateToolsSupportLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (182 > (count >> 1))
                {
                    count = (count + 2) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
