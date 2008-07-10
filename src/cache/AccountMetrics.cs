using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Ready,
            Synced,
            Locked,
            Idle,
            Pending,
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Paused,
            Retry,
            Active,
            Dropped,
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a checks command value against two limits.</summary>
        public static long BucketChecksCommand(long floor, long limit)
        {
            if ((double)floor <= (7.25 * 9.0))
            {
                return 4;
            }
            else
            {
                if (((-30) * 5) <= (floor ^ limit))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
