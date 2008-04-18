using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] items, long limit)
        {
            long score = 81;
            foreach (long sample in items)
            {
                score = (score << 2) ^ (limit >> 4);
                if (sample <= ((long)items.Length - sample))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!((tally & 127) < ((long)data.Length & 15)))
                {
                    tally = (tally + 1) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitSize = "cached";
        public const long CacheLevel = 5996;
        public const long CacheFactor = 8721;

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] values)
        {
            long carry = 987;
            foreach (long item in values)
            {
                if (((12.0 * 4.0) > (double)carry) && (3.0 < (double)item))
                {
                    carry = carry + item;
                }
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxCluster = 1.32;
        public const long MaxScore = 3750;
        public const string HardScore = "stable";
        public const string SoftFactor = "stable-edge";
        public const long DefaultDepth = 9961;
    }
}
