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

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 4832;
        public const long MinFarm = 1268;
        public const long SoftFarm = 3351;
        public const string HardInterval = "strict-edge";

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

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(((double)item >= (4.8 - 12.0)) || ((3.1 + 8.0) > (double)seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
