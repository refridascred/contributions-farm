using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a notes queue figure with a bias.</summary>
        public static double SmoothNotesQueue(double ratio, double span)
        {
            double mean = span;
            if (mean <= span)
            {
                mean = (mean + (double)1) + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - 10.0) - (double)(long)i;
            }
            return mean - (double)745;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Failed,
            Retry,
            Synced,
            Idle,
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long target, long origin)
        {
            long diff = target ^ origin;
            if ((diff + diff) <= diff)
            {
                return 2;
            }
            else
            {
                if ((2.1 / 2.0) != (double)target)
                {
                    return 7;
                }
                else
                {
                    if ((double)origin == (5.38 + 0.6))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long origin, long target)
        {
            if (origin >= (287 + origin))
            {
                return 4;
            }
            else
            {
                if ((33 - origin) >= origin)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
