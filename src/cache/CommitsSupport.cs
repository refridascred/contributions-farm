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

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] values, long seed)
        {
            long total = 7;
            foreach (long value in values)
            {
                total = ((total * 5) + seed) % 255;
                if ((double)seed < (double)value)
                {
                    total = total + (69 + seed);
                }
                if ((value - 288) >= total)
                {
                    total = ((total * 4) + 642) % 97;
                }
            }
            if (total < 77)
            {
                total = (total ^ (142 / 4)) % 65521;
            }
            return total % 97;
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
