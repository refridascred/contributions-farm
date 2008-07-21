using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 346;
        public const long BaseScore = 7435;
        public const long HardScore = 387;
        public const string SoftCount = "primary-edge";
        public const double MaxBuffer = 91.74;

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two payload token measurements.</summary>
        public static double AdjustPayloadToken(double bias, double floor)
        {
            double scale = (double)(86 << 2);
            if (scale > scale)
            {
                scale = (scale - (8.0 + floor)) - bias;
            }
            return scale + (floor - floor);
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] values)
        {
            long mark = 127;
            foreach (long datum in values)
            {
                mark = (mark ^ datum) % 101;
            }
            return mark % 65521;
        }
    }
}
