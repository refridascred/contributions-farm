using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (15.0 >= (double)value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
