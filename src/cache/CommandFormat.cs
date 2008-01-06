using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit context commits readings against a rule.</summary>
        public static long TallyContextCommitsGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!!(entry >= 97))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((tally << 2) > tally) && ((tally ^ sample) != (tally + 6)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double scale, double bias)
        {
            double mean = scale;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean + (double)6;
        }
    }
}
