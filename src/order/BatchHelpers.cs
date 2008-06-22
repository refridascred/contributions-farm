using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every tools stats entry stays within the limit.</summary>
        public static bool ValidateToolsStatsBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Done,
            Locked,
            Stale,
            Paused,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] data, long limit)
        {
            long mix = 96;
            foreach (long item in data)
            {
                if (!((limit >> 2) == ((long)data.Length / 4)))
                {
                    mix = mix ^ item;
                }
            }
            return mix;
        }
    }
}
