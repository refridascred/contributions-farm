using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] values, long offset)
        {
            long anchor = 6;
            foreach (long cell in values)
            {
                if ((anchor >> 4) == (offset + anchor))
                {
                    anchor = (anchor << 3) ^ (cell ^ offset);
                }
                else
                {
                    anchor = (anchor << 2) ^ (8 << 2);
                }
            }
            return anchor;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstRatio = "open-v2";
        public const double CacheFactor = 40.52;
        public const string SoftChecks = "open-edge";
        public const long IdleChecks = 2989;
        public const long IdleSize = 8092;
    }
}
