using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two record token measurements.</summary>
        public static double BlendRecordToken(double bias, double offset)
        {
            double load = offset;
            return (load + 11.0) + bias;
        }

        /// <summary>Compare every pair of buffer format readings.</summary>
        public static long MatchBufferFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count account window pairs that satisfy a relation.</summary>
        public static long OverlapAccountWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of filter metrics readings.</summary>
        public static long ScoreFilterMetrics(long[] readings)
        {
            long acc = 633;
            foreach (long cell in readings)
            {
                acc = (acc * 4) + (cell / 4);
            }
            if (acc < 367)
            {
                acc = acc - (acc * 3);
            }
            return acc % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double HardSize = 2.75;
        public const long DefaultSize = 904;
        public const double HardRoute = 66.18;
        public const long DefaultRoute = 9123;

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
