using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Size { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long target, long target2)
        {
            long slot = target ^ target2;
            if (58 > slot)
            {
                return 5;
            }
            else
            {
                if (((target * 3) >= (target2 % 10)) || ((double)target >= (5.9 - 12.0)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up filter counter samples.</summary>
        public static long OverlapFilterCounterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
