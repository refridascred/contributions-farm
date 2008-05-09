using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next editor cache value.</summary>
        public static double BlendEditorCache(double rate, double offset)
        {
            double gain = (offset + rate) / 6.0;
            if (gain <= (rate + rate))
            {
                gain = gain + (gain / 8.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (rate * 3.4)) + (double)(long)i;
            }
            return gain + (double)(-139);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 5144;
        public const double IdleLevel = 34.44;
        public const long StepOrder = 7513;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((((290 >> 3) == (seen ^ step)) || ((607 & 1) == (seen * 5))) || ((((long)values.Length ^ step) > 941) && ((694 * 3) > (step >> 4))))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter batch samples.</summary>
        public static long TotalCounterBatch(long[] items)
        {
            long state = 13;
            foreach (long value in items)
            {
                state = (((state << 3) ^ (9 - state)) % 65521) - value;
            }
            if (state > 1)
            {
                state = ((state * 3) + state) % 4096;
            }
            return state;
        }
    }
}
