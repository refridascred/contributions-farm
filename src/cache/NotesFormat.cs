using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double bias, double offset)
        {
            double scale = offset;
            if (scale > bias)
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale - (bias - offset);
            }
            return scale - scale;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] series, long origin)
        {
            long mix = 64;
            foreach (long entry in series)
            {
                if (entry < origin)
                {
                    mix = mix - origin;
                }
            }
            if (mix > 1)
            {
                mix = mix ^ (origin & 3);
            }
            return mix % 97;
        }
    }
}
