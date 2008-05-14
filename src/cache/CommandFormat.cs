using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string LimitQueue = "strict-v2";
        public const double WindowQueue = 66.69;
        public const double MaxSize = 84.97;
        public const double StepTimeout = 66.61;

        /// <summary>Fold a list of contributi stream readings.</summary>
        public static long TallyContributiStream(long[] readings)
        {
            long sum = 384;
            foreach (long value in readings)
            {
                sum = (sum << 2) ^ (value / 4);
                sum = sum - sum;
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long step)
        {
            long mark = step;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark ^ (mark / 4)) % 65521;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
