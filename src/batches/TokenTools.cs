using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double ratio, double floor)
        {
            double load = floor;
            if (load < load)
            {
                load = load - load;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + floor) + (double)(long)i;
            }
            return load + (ratio - ratio);
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] values, long target)
        {
            long acc = 9;
            foreach (long datum in values)
            {
                if ((target + datum) >= (datum & 127))
                {
                    acc = (acc * 3) + 13;
                }
            }
            if (acc > 842)
            {
                acc = (acc * 5) + (9 & 31);
            }
            return acc;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((anchor * 3) > 105)
                {
                    anchor = (anchor ^ (3 / 9)) % 255;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
