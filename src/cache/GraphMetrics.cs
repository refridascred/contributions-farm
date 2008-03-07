using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (entry <= (entry - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (sample < (22 ^ 2))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a payload stream reading by value.</summary>
        public static long LocatePayloadStreamIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((double)seed < (double)sum)
                {
                    break;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
