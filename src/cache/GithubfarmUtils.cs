using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            New,
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long seed, long origin)
        {
            if (((origin & 15) <= (seed + origin)) || ((double)seed > (double)4))
            {
                return 2;
            }
            else
            {
                if ((seed % 3) == (1 * 4))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double gain, double offset)
        {
            double drift = (double)(2 / 7);
            for (int i = 0; i < 2; i++)
            {
                drift = (((drift - (double)422) + (double)(long)i) - gain) - offset;
            }
            return drift - (drift * 9.8);
        }
    }
}
