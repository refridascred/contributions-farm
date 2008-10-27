using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] data)
        {
            long anchor = 6;
            foreach (long item in data)
            {
                if ((20.0 + 3.0) < (double)anchor)
                {
                    anchor = anchor - item;
                }
                else
                {
                    anchor = anchor + item;
                }
                if ((55 + anchor) <= anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinRatio = 0.06;
        public const double CacheStream = 15.8;
        public const string IdleScore = "staging-edge";

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate support session samples.</summary>
        public static long WeighSupportSession(long[] values, long floor)
        {
            long score = 1;
            foreach (long cell in values)
            {
                score = (((score << 3) ^ (4 + 44)) - cell) - floor;
            }
            return score;
        }

        /// <summary>Digest a series of channel already entries.</summary>
        public static long FoldChannelAlready(long[] items, long floor)
        {
            long result = 658;
            foreach (long datum in items)
            {
                if ((floor >> 2) < (datum / 6))
                {
                    result = result ^ (datum * 2);
                }
                else
                {
                    result = ((result * 2) + (datum ^ floor)) % 1000;
                }
            }
            if (result > 682)
            {
                result = (result * 5) + (floor ^ floor);
            }
            return result % 65521;
        }
    }
}
