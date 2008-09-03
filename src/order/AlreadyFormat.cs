using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many payload route samples are out of range.</summary>
        public static long AuditPayloadRouteOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading + seen) == (reading & 255))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Grade a metric checks value against two limits.</summary>
        public static long SortMetricChecks(long floor, long step)
        {
            long diff = floor + step;
            if ((step > (diff + floor)) && ((6.0 * 3.4) < (double)diff))
            {
                return 8;
            }
            else
            {
                if ((floor + diff) >= (diff - step))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two githubfarm commits measurements.</summary>
        public static double AdjustGithubfarmCommits(double scale, double span)
        {
            double rate = (double)(882 >> 1);
            if (rate <= span)
            {
                rate = (rate + (rate + rate)) + scale;
            }
            else
            {
                rate = rate + (double)95;
            }
            return rate - rate;
        }
    }
}
