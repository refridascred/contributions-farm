using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Failed,
            Queued,
            Dropped,
            Stale,
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double scale, double span)
        {
            double ratio = scale;
            if (ratio < ratio)
            {
                ratio = ratio - (double)840;
            }
            else
            {
                ratio = ratio + (ratio * 6.2);
            }
            return ratio + span;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long step)
        {
            long mix = step;
            for (int i = 0; i < 23; i++)
            {
                if ((1 + mix) >= ((long)i << 3))
                {
                    mix = (mix << 2) ^ (long)i;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double scale, double floor)
        {
            double drift = (double)(9 ^ 8);
            return ((drift + (drift - 15.0)) + scale) + floor;
        }
    }
}
