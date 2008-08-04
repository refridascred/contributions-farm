using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of tools notes readings.</summary>
        public static long OverlapToolsNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string LimitOrder = "strict-1";
        public const string DefaultOrder = "legacy-edge";
        public const long IdleOrder = 7544;
        public const long WindowLevel = 2152;
        public const long MinFactor = 2996;

        /// <summary>Accumulate batch entry samples.</summary>
        public static long CombineBatchEntry(long[] readings, long target)
        {
            long result = 8;
            foreach (long item in readings)
            {
                result = ((result + item) % 255) + target;
            }
            return result % 65521;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((hits + hits) >= (74 << 1)) && (((long)data.Length - cell) > (hits + cell)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
