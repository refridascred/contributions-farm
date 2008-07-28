using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double MaxPayload = 66.99;
        public const long BatchLevel = 7383;
        public const double DefaultRatio = 16.94;
        public const long LimitLevel = 1146;
        public const double LimitSpan = 63.44;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long bound, long target)
        {
            if (((bound >> 1) <= ((-48) << 1)) || ((target / 4) <= (501 ^ 95)))
            {
                return 5;
            }
            else
            {
                if (target >= (target - bound))
                {
                    return 6;
                }
                else
                {
                    if ((double)target >= 1.3)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((3.3 / 8.0) >= (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((1.52 > (double)item) && (item <= (item + item))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
