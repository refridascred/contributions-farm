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

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double rate, double floor)
        {
            double mean = (double)(234 - 71);
            if (mean > (floor / 9.0))
            {
                mean = (mean - mean) + rate;
            }
            else
            {
                mean = mean - 0.87;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (double)4) + (double)(long)i;
            }
            return mean + (floor / 3.0);
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((reading % 3) < bound) || ((bound >> 2) >= (bound >> 3)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
