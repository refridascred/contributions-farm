using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = (state + (long)i) % 1000;
                state = (state * 3) + ((long)i % 2);
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (matches > (reading % 24))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long bound, long step)
        {
            if (!((bound + step) > step))
            {
                return 6;
            }
            else
            {
                if ((double)step < 6.27)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
