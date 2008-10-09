using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((seed < (seed + entry)) || ((double)seed == (1.9 / 8.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxRatio = 2654;
        public const long HardFarm = 7079;
        public const string LimitDepth = "stable-v2";
        public const long LimitFarm = 4411;
        public const long StepBudget = 7502;

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
