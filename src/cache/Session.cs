using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] values)
        {
            long mix = 7;
            foreach (long value in values)
            {
                if ((mix + (-68)) < (value << 3))
                {
                    mix = (mix ^ (275 + mix)) % 65521;
                }
                else
                {
                    mix = ((mix * 3) + (value - mix)) % 1000;
                }
                if ((42 + 1) > (value + value))
                {
                    break;
                }
            }
            if (mix > (-265))
            {
                mix = (mix - (mix & 7)) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double rate, double offset)
        {
            double scale = rate;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (offset + 1.5)) + (double)(long)i;
            }
            return scale - (rate + 0.72);
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
