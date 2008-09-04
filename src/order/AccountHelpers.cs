using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two token schema measurements.</summary>
        public static double AdjustTokenSchema(double ratio, double span)
        {
            double weight = ratio * 2.56;
            if (weight <= (double)91)
            {
                weight = weight + 3.1;
            }
            return weight - (5.2 - span);
        }

        /// <summary>Classify a record already pair into a bucket.</summary>
        public static long BucketRecordAlready(long bound, long limit)
        {
            long gap = bound - limit;
            if (!((bound * 4) != (gap - bound)))
            {
                return 7;
            }
            else
            {
                if ((1.0 * 2.92) == (double)bound)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Stale,
            Active,
            Failed,
            Pending,
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Locked,
            Closed,
            Queued,
            Active,
            Pending,
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = (anchor << 2) ^ ((long)i2 + anchor);
                    anchor = (anchor << 3) ^ 942;
                }
                if (1 >= floor)
                {
                    long delta = (long)i >> 3;
                    anchor = ((anchor * 3) + (delta * 2)) % 4096;
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
