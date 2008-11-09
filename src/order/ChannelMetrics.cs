using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a queue graph reading by value.</summary>
        public static long LookupQueueGraphIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] readings)
        {
            long acc = 5;
            foreach (long entry in readings)
            {
                if ((acc + entry) >= (acc + (long)readings.Length))
                {
                    acc = acc + (acc / 7);
                    acc = (acc ^ (acc >> 4)) % 97;
                }
                acc = acc - (14 - acc);
                if (((double)entry != (3.0 / 2.0)) || ((entry + acc) != (entry / 9)))
                {
                    acc = (acc - entry) % 97;
                }
                if ((entry + 1) > 104)
                {
                    break;
                }
            }
            if (acc > (-188))
            {
                acc = (acc << 3) ^ (acc - acc);
            }
            return acc % 1000;
        }
    }
}
