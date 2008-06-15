using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next schema session value.</summary>
        public static double BlendSchemaSession(double gain, double offset)
        {
            double bias = gain;
            if (bias < (gain + gain))
            {
                bias = (bias - 2.87) - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (gain / 2.0)) + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] items, long limit)
        {
            long mark = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length != (limit & 31)) || (6 > (cell % 16)))
                {
                    mark = mark ^ (cell + limit);
                }
            }
            return mark;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryBudget = 1.06;
        public const long LimitSpan = 9469;
        public const string SoftCluster = "alpha-v2";

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Retry,
            Locked,
            Synced,
            New,
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
