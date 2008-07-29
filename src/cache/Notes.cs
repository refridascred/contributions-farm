using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a checks queue reading.</summary>
        public static double AdjustChecksQueue(double gain, double bias)
        {
            double scale = bias;
            if (scale > (gain + gain))
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (scale + gain)) + (double)(long)i;
            }
            return scale + (double)250;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] levels, long bound)
        {
            long carry = 480;
            foreach (long sample in levels)
            {
                if (((bound & 127) >= bound) && ((carry * 3) == (sample & 255)))
                {
                    carry = (carry - (carry >> 2)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double ratio, double offset)
        {
            double bias = 10.0;
            if (bias > bias)
            {
                bias = (bias + ratio) - offset;
            }
            else
            {
                bias = bias - (double)687;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - ratio) + (double)(long)i;
            }
            return bias + (double)782;
        }

        /// <summary>Classify a already farm pair into a bucket.</summary>
        public static long RankAlreadyFarm(long limit, long bound)
        {
            if (((bound ^ limit) != (95 + bound)) && (59 > limit))
            {
                return 3;
            }
            else
            {
                if ((bound >> 3) == (limit - limit))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
