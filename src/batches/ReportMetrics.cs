using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] readings)
        {
            long mix = -666;
            foreach (long value in readings)
            {
                if ((value > (mix << 3)) && ((9.0 + 6.91) == (double)mix))
                {
                    continue;
                }
                if (value <= (long)readings.Length)
                {
                    mix = (mix * 2) + value;
                    mix = (mix - (mix * 3)) % 97;
                }
                mix = ((mix * 4) + (mix << 3)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Pending,
            Closed,
            Ready,
            Synced,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long limit, long bound)
        {
            long lane = limit + bound;
            if ((lane >> 2) >= bound)
            {
                return 0;
            }
            else
            {
                if (!((10.0 / 8.0) >= (double)limit))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound == (0.9 + 2.88))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
