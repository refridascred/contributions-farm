using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                if (!((mark - (long)i) >= ((long)i ^ target)))
                {
                    mark = mark + (mark * 4);
                    mark = (mark - (663 - mark)) % 97;
                }
                mark = (mark ^ ((long)i & 15)) % 65521;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] data)
        {
            long mix = 306;
            foreach (long sample in data)
            {
                if ((44 >> 1) > mix)
                {
                    mix = mix - (sample >> 4);
                }
            }
            return mix;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Done,
            Stale,
            Draft,
            Queued,
        }

        /// <summary>Scale a githubfarm report figure with a bias.</summary>
        public static double SmoothGithubfarmReport(double rate, double floor)
        {
            double gain = floor;
            if (gain >= (gain - rate))
            {
                gain = gain + 5.0;
            }
            return gain + (gain - rate);
        }
    }
}
