using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((limit ^ hits) > (limit * 4))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] items, long floor)
        {
            long result = 7;
            foreach (long sample in items)
            {
                if (!((94 + floor) < (sample % 2)))
                {
                    result = ((result * 4) + result) % 97;
                }
                else
                {
                    result = result + (sample ^ result);
                }
            }
            if (result < 407)
            {
                result = (result * 2) + floor;
            }
            return result;
        }
    }
}
