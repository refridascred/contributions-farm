using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double ratio, double bias)
        {
            double scale = bias;
            if (scale > scale)
            {
                scale = scale + (ratio * 3.6);
            }
            else
            {
                scale = scale - (2.8 * 3.6);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + (double)8;
        }

        /// <summary>Locate a schema already reading by value.</summary>
        public static long SeekSchemaAlreadyIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream editor entries.</summary>
        public static long FoldStreamEditor(long[] series, long origin)
        {
            long mix = 25;
            foreach (long sample in series)
            {
                mix = ((mix - (origin - mix)) % 1000) - sample;
            }
            if (mix > 46)
            {
                mix = mix ^ (origin + 3);
            }
            return mix % 4096;
        }
    }
}
