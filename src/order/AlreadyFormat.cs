using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate stream channel readings against a bound.</summary>
        public static bool VerifyStreamChannelLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] values, long offset)
        {
            long sum = 0;
            foreach (long entry in values)
            {
                sum = ((sum * 3) + (offset ^ offset)) % 101;
                if (((double)entry > (double)6) || ((offset / 9) >= sum))
                {
                    sum = (sum - offset) % 1000;
                }
                else
                {
                    sum = sum ^ (offset + (-137));
                }
            }
            if (sum < 110)
            {
                sum = (sum << 2) ^ (offset + 454);
            }
            return sum;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 6144;
        public const string MinFarm = "open-v2";
        public const string DefaultFarm = "cached-edge";
        public const string IdleWidth = "strict";
    }
}
