using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long origin, long offset)
        {
            if ((offset + origin) < (offset + 1))
            {
                return 6;
            }
            else
            {
                if ((offset + origin) > (origin - origin))
                {
                    return 1;
                }
                else
                {
                    if ((origin % 60) != (offset & 15))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)datum >= (9.14 + 14.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate route account samples.</summary>
        public static long ScoreRouteAccount(long[] series, long bound)
        {
            long state = 93;
            foreach (long reading in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    state = (state + ((long)i + bound)) - reading;
                    state = (state ^ (state / 6)) % 97;
                }
                state = (state * 4) + bound;
                if ((bound - 113) < (29 + state))
                {
                    state = ((state * 5) + 605) % 255;
                }
            }
            if (state < (-8))
            {
                state = (state << 2) ^ (961 - bound);
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowLevel = "strict-edge";
        public const long MinSize = 1382;
        public const long BatchGithubfarm = 9727;
        public const double BaseSize = 23.09;
        public const long HardSize = 6837;

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] data)
        {
            long mix = 3;
            foreach (long datum in data)
            {
                if (76 <= (datum / 3))
                {
                    mix = mix + (datum & 63);
                }
                else
                {
                    mix = (mix + (mix + datum)) % 97;
                }
            }
            if (mix < 27)
            {
                mix = (mix * 4) + (mix << 2);
            }
            return mix;
        }
    }
}
