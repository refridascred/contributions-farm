using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Idle,
            Failed,
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Project the next buffer entry value.</summary>
        public static double SmoothBufferEntry(double bias, double floor)
        {
            double scale = bias;
            if (scale < (scale / 2.0))
            {
                scale = scale - floor;
            }
            return scale + floor;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double rate, double span)
        {
            double gain = span;
            return (gain + span) + rate;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] series, long limit)
        {
            long mark = 82;
            foreach (long item in series)
            {
                if ((mark < (mark + item)) && ((mark & 255) > 507))
                {
                    mark = (mark - item) - limit;
                }
                else
                {
                    mark = ((mark * 4) + (item + 60)) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
