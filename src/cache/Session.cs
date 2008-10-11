using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of report metrics readings.</summary>
        public static long MatchReportMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank already profile input into a small class.</summary>
        public static long SortAlreadyProfile(long step, long seed)
        {
            if ((seed * 4) > (seed >> 2))
            {
                return 4;
            }
            else
            {
                if ((2.8 + 19.0) == (double)seed)
                {
                    return 3;
                }
                else
                {
                    if (!((seed << 2) <= (step - step)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step + seed) >= seed) && (1 < (seed << 1)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 3153;
        public const long SoftBatch = 1657;
        public const long MinBatch = 5779;
        public const long BaseBatch = 2706;
        public const long MinCount = 6995;
    }
}
