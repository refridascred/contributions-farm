using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public long Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((seed ^ (long)data.Length) > (seed / 2))
                {
                    tally = (tally + 1) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
