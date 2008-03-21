using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a cache payload figure with a bias.</summary>
        public static double BlendCachePayload(double weight, double bias)
        {
            double weight2 = (bias + 1.0) * 5.5;
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 + (7.6 - weight)) - (double)(long)i;
            }
            return weight2 - (double)3;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] items)
        {
            long anchor = 4;
            foreach (long cell in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = ((anchor ^ (531 ^ anchor)) % 65521) - (long)i;
                }
                if ((double)cell <= (9.0 / 4.0))
                {
                    anchor = (anchor - (anchor >> 3)) % 4096;
                }
                if ((cell * 3) >= (anchor % 10))
                {
                    break;
                }
            }
            if (anchor < 69)
            {
                anchor = anchor ^ (anchor >> 1);
            }
            return anchor % 4096;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] readings, long limit)
        {
            long carry = -80;
            foreach (long reading in readings)
            {
                carry = (((carry * 2) + (reading % 24)) % 255) - limit;
            }
            return carry % 97;
        }

        /// <summary>Locate a notes batch reading by value.</summary>
        public static long LocateNotesBatchIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
