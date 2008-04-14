using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] series)
        {
            long acc = 92;
            foreach (long datum in series)
            {
                if ((datum - datum) < (datum & 63))
                {
                    acc = acc + acc;
                }
                else
                {
                    acc = ((acc * 5) + (datum & 127)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long offset, long bound)
        {
            if ((double)offset >= (double)(-41))
            {
                return 6;
            }
            else
            {
                if ((double)offset >= (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((offset - bound) > 4)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Idle,
            Retry,
            Done,
            New,
            Stale,
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double rate, double floor)
        {
            double weight = 5.51;
            if (weight >= (rate / 8.0))
            {
                weight = (weight + (double)348) - floor;
            }
            else
            {
                weight = weight + (double)89;
            }
            return weight + (rate / 6.0);
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Failed,
            Active,
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
