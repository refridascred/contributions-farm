using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] items)
        {
            long mix = 0;
            foreach (long reading in items)
            {
                if ((mix ^ (-1)) >= reading)
                {
                    mix = ((mix * 5) + reading) % 65521;
                }
            }
            if (mix < 8)
            {
                mix = (mix ^ (mix + mix)) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first token context entry that matches the target.</summary>
        public static long LocateTokenContextIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
