using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double rate, double floor)
        {
            double ratio = (double)((-8) % 7);
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio + (double)(long)i) - rate) - floor;
            }
            return ratio + 1.88;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Draft,
            Dropped,
            Failed,
            Synced,
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = ((mix << 3) ^ seed) - (long)i2;
                    mix = (mix << 3) ^ mix;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] levels, long seed)
        {
            long anchor = 17;
            foreach (long value in levels)
            {
                anchor = (anchor + (3 % 24)) - value;
                anchor = anchor + (anchor - anchor);
                if ((anchor % 5) > (anchor / 5))
                {
                    break;
                }
            }
            if (anchor > 7)
            {
                anchor = ((anchor * 4) + (seed / 5)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Match up channel token samples.</summary>
        public static long MatchChannelTokenCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
