using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Closed,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Compare every pair of notes session readings.</summary>
        public static long MatchNotesSessionCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two context batch measurements.</summary>
        public static double AdjustContextBatch(double bias, double span)
        {
            double load = 6.4;
            if (load < load)
            {
                load = (load - (7.0 + span)) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load / 8.0)) - (double)(long)i;
            }
            return load + 6.74;
        }
    }
}
