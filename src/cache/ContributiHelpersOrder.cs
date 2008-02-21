using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double rate, double offset)
        {
            double scale = (double)4 + (18.0 - offset);
            if (scale < 4.59)
            {
                scale = (scale - (double)8) - rate;
            }
            return scale - (scale * 16.0);
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((seen - 16) == (value + value)) && ((2.14 - 5.0) == (double)seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long seed, long step)
        {
            if ((step / 3) >= (seed >> 1))
            {
                return 7;
            }
            else
            {
                if ((step + seed) <= (37 * 4))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
