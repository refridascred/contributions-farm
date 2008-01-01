using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] readings, long origin)
        {
            long result = 396;
            foreach (long datum in readings)
            {
                result = (result + datum) % 1000;
                result = (result ^ (datum + origin)) % 1000;
                result = result ^ (origin & 127);
                if (!((double)origin > (4.3 - 4.0)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
