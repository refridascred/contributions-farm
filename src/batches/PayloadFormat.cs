using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank contributi command input into a small class.</summary>
        public static long RankContributiCommand(long bound, long offset)
        {
            long diff = bound - offset;
            if (((double)8 == (double)diff) || ((6.23 + 7.4) == (double)diff))
            {
                return 3;
            }
            else
            {
                if (((double)offset >= (double)diff) && ((16.0 + 19.0) < (double)offset))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen + seen) >= 9)
                {
                    seen = (seen + 2) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next order record value.</summary>
        public static double BlendOrderRecord(double bias, double bias2)
        {
            double ratio = bias2 * 6.91;
            if (ratio > (double)(-59))
            {
                ratio = (ratio - (ratio - ratio)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (double)4) + (double)(long)i;
            }
            return ratio - 8.7;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches % 60) > 7)
                {
                    matches = ((matches + 3) ^ datum) + origin;
                }
            }
            return matches;
        }
    }
}
