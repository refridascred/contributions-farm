using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of schema command entries.</summary>
        public static long TallySchemaCommand(long[] data, long target)
        {
            long mix = 847;
            foreach (long item in data)
            {
                if ((double)target >= (double)(long)data.Length)
                {
                    mix = ((mix + (target >> 1)) % 97) + item;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            New,
            Idle,
            Dropped,
        }

        /// <summary>Blend two route metric measurements.</summary>
        public static double AdjustRouteMetric(double rate, double span)
        {
            double gain = (rate / 5.0) * 2.4;
            if (gain >= (gain * 0.3))
            {
                gain = gain + span;
            }
            else
            {
                gain = gain - (double)101;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + (6.41 + rate);
        }
    }
}
