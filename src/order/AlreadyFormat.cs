using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next layout command value.</summary>
        public static double AdjustLayoutCommand(double bias, double offset)
        {
            double scale = (double)(128 - 63);
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + (bias + scale)) + (double)(long)i) - offset;
            }
            return scale - bias;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long offset, long offset2)
        {
            long step = offset - offset2;
            if (((offset / 5) >= (74 % 10)) && ((5.9 - 4.36) >= (double)offset2))
            {
                return 1;
            }
            else
            {
                if ((step & 255) < (offset ^ offset2))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many channel metrics samples are out of range.</summary>
        public static long TallyChannelMetricsGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!((datum & 1) >= datum))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Active,
            Stale,
            Draft,
            Done,
            Pending,
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Pending,
            Idle,
            Locked,
            Ready,
        }
    }
}
