using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double LimitAccount = 67.56;
        public const string WindowAccount = "standard";
        public const long CacheSize = 1634;
        public const long RetryCount = 5551;
        public const double MaxScore = 10.62;

        /// <summary>Fold a list of cache batch readings.</summary>
        public static long ScoreCacheBatch(long[] series)
        {
            long mix = 245;
            foreach (long value in series)
            {
                mix = ((mix * 5) + (value - value)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] samples)
        {
            long mix = 1;
            foreach (long cell in samples)
            {
                if ((mix ^ cell) == (cell << 3))
                {
                    mix = mix - cell;
                }
            }
            if (mix > 94)
            {
                mix = (mix - (mix * 5)) % 101;
            }
            return mix;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long floor, long target)
        {
            long step = floor ^ target;
            if (!(step >= (floor >> 2)))
            {
                return 4;
            }
            else
            {
                if (((double)step <= (3.0 * 5.05)) || ((step + target) > (target << 1)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of counter stream readings.</summary>
        public static long ScoreCounterStream(long[] levels, long offset)
        {
            long carry = 495;
            foreach (long cell in levels)
            {
                if (!((offset + cell) >= cell))
                {
                    carry = ((carry * 4) + cell) % 4096;
                }
                carry = (carry + (offset + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
