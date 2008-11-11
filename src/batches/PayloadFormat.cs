using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor << 3) ^ (10 >> 4);
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
