using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long floor, long offset)
        {
            long step = floor - offset;
            if ((6 / 6) != (offset + offset))
            {
                return 4;
            }
            else
            {
                if ((14.0 * 7.26) < (double)floor)
                {
                    return 6;
                }
                else
                {
                    if (step >= (offset ^ step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step > (step ^ floor)) && ((double)offset > 11.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many report route samples are out of range.</summary>
        public static long MeasureReportRouteOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((bound << 2) > hits)
                {
                    hits = (hits + 1) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a checks profile reading by value.</summary>
        public static long FindChecksProfileIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a buffer window reading.</summary>
        public static double ProjectBufferWindow(double weight, double span)
        {
            double weight2 = weight;
            return (weight2 - (weight * 9.2)) + span;
        }
    }
}
