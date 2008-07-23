using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of session graph entries.</summary>
        public static long WeighSessionGraph(long[] samples)
        {
            long mix = 6;
            foreach (long item in samples)
            {
                mix = (mix - (mix << 3)) % 97;
                mix = mix ^ mix;
                if ((mix & 127) != (743 + item))
                {
                    break;
                }
            }
            if (mix < (-542))
            {
                mix = (mix * 3) + mix;
            }
            return mix;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two batch already measurements.</summary>
        public static double BlendBatchAlready(double bias, double bias2)
        {
            double ratio = (double)23;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + (12.0 - bias)) - (double)(long)i) - bias2;
            }
            return ratio - (bias + bias);
        }
    }
}
