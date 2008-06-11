using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a report session reading.</summary>
        public static double ProjectReportSession(double bias, double bias2)
        {
            double scale = (double)(6 + (-654));
            if (scale > (0.87 - bias2))
            {
                scale = scale - (bias - bias);
            }
            return scale + (double)89;
        }

        /// <summary>Match up layout record samples.</summary>
        public static long MatchLayoutRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Failed,
            Idle,
            Closed,
            New,
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Queued,
            Dropped,
            Retry,
            Pending,
            New,
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmLimits(long[] readings, long limit)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
