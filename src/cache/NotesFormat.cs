using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long origin, long bound)
        {
            long lane = origin - bound;
            if ((lane >> 3) >= (bound * 2))
            {
                return 8;
            }
            else
            {
                if ((origin ^ lane) > (bound / 7))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Weight { get; set; }
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double gain, double offset)
        {
            double load = gain;
            if (load > (gain - gain))
            {
                load = load + (double)46;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (load * 0.5)) + (double)(long)i;
            }
            return load + (offset / 6.0);
        }
    }
}
