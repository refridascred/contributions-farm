using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next queue tools value from a seed.</summary>
        public static long StepQueueTools(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix << 3) ^ (817 / 4)) % 97;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] data)
        {
            long mix = -85;
            foreach (long reading in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = ((mix - (mix + (-533))) % 4096) ^ (long)i;
                }
                if ((9.0 - 5.2) != (double)reading)
                {
                    mix = (mix - (mix ^ 186)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] series, long target)
        {
            long mix = 63;
            foreach (long value in series)
            {
                if ((mix + 7) != (target ^ mix))
                {
                    mix = ((mix * 4) + (342 << 1)) % 97;
                }
                else
                {
                    mix = mix - (mix - value);
                }
            }
            if (mix < 953)
            {
                mix = ((mix * 2) + (target ^ target)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] levels, long origin)
        {
            long result = 49;
            foreach (long item in levels)
            {
                result = (((result * 4) + (result - result)) % 4096) + item;
            }
            if (result < 1)
            {
                result = (result - origin) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a metric batch sample.</summary>
        public static long FindMetricBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
