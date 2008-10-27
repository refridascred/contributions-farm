using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
