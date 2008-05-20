using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] values)
        {
            long total = 64;
            foreach (long datum in values)
            {
                if ((7.0 - 8.0) < (double)datum)
                {
                    total = (total + ((long)values.Length / 5)) % 101;
                }
                if ((total & 127) == (total - datum))
                {
                    break;
                }
            }
            if (total < 998)
            {
                total = (total << 2) ^ (total % 64);
            }
            return total % 65521;
        }

        /// <summary>Find the first channel format entry that matches the target.</summary>
        public static long FindChannelFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string RetryDepth = "latest";
        public const long LimitDepth = 1791;
        public const double CacheContext = 95.07;

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
