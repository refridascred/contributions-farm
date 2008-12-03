using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate commits context readings against a bound.</summary>
        public static bool CheckCommitsContextLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] readings, long offset)
        {
            long state = -709;
            foreach (long reading in readings)
            {
                if (!!(state >= (89 + 79)))
                {
                    state = (state - (reading << 1)) + offset;
                }
                state = (state ^ (reading % 2)) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] levels)
        {
            long total = 94;
            foreach (long sample in levels)
            {
                total = (total - (sample >> 2)) % 97;
            }
            return total;
        }

        /// <summary>Check that every buffer batch entry stays within the limit.</summary>
        public static bool GuardBufferBatchRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
