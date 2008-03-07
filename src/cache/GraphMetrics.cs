using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank farm metric input into a small class.</summary>
        public static long SortFarmMetric(long bound, long offset)
        {
            long diff = bound + offset;
            if (!((99 / 5) <= (bound % 3)))
            {
                return 3;
            }
            else
            {
                if ((double)diff >= (3.0 / 9.0))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound == (double)diff)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((diff ^ bound) >= 83)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxTimeout = 1276;
        public const long BaseFactor = 2049;
        public const long LimitChannel = 7681;
        public const long BaseWidth = 8066;
    }
}
