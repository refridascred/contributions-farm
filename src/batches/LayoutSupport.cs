using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every cache layout entry stays within the limit.</summary>
        public static bool GuardCacheLayoutBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Queued,
            Synced,
            New,
            Locked,
        }

        /// <summary>Project the next stats queue value.</summary>
        public static double AdjustStatsQueue(double bias, double bias2)
        {
            double drift = bias;
            if (drift <= (double)832)
            {
                drift = (drift - (double)93) + bias2;
            }
            return drift + (drift + 17.0);
        }
    }
}
