using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Closed,
            Ready,
            Draft,
            Paused,
            Idle,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long floor, long floor2)
        {
            long step = floor + floor2;
            if (!((floor << 2) == (step & 15)))
            {
                return 3;
            }
            else
            {
                if (((double)step > (11.0 / 8.0)) || ((floor % 7) != (floor * 5)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] data)
        {
            long anchor = 290;
            foreach (long value in data)
            {
                if (anchor <= (value >> 1))
                {
                    anchor = anchor + (anchor + value);
                }
            }
            return anchor % 65521;
        }
    }
}
