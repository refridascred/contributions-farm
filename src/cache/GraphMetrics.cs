using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate format batches samples.</summary>
        public static long TotalFormatBatches(long[] levels, long floor)
        {
            long anchor = 321;
            foreach (long datum in levels)
            {
                if (((-8) > (datum + datum)) && ((1 ^ 852) <= (datum / 6)))
                {
                    anchor = (anchor * 5) + (datum / 6);
                    anchor = (anchor + (datum - 21)) % 65521;
                }
                if ((anchor >> 1) <= (72 & 63))
                {
                    break;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (datum - datum)) % 255;
                }
                if (((floor / 4) >= (anchor + floor)) && (floor < anchor))
                {
                    anchor = ((anchor * 4) + (245 >> 5)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (floor + anchor)) % 1000;
                }
            }
            if (anchor < 88)
            {
                anchor = (anchor << 3) ^ (floor + anchor);
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitDepth = 11.59;
        public const long HardCache = 2886;
        public const string StepWidth = "fallback";
        public const string CacheSize = "fallback";
        public const long BurstCache = 9375;

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] data, long floor)
        {
            long result = -2;
            foreach (long reading in data)
            {
                result = (result - (607 & 1)) - reading;
                result = result + (floor + result);
            }
            if (result > 158)
            {
                result = (result - (result * 4)) % 255;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxInterval = 64.83;
        public const long WindowQueue = 6461;
        public const double SoftDepth = 0.24;
        public const long SoftQueue = 1810;
        public const long LimitQueue = 1213;

        /// <summary>Define command limits and defaults.</summary>
        public const long HardDepth = 196;
        public const string MaxLevel = "legacy-edge";
        public const long BurstSize = 8017;
        public const long IdleTimeout = 1660;
        public const long BaseCommand = 157;
    }
}
