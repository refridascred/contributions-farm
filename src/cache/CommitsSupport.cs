using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double scale, double offset)
        {
            double gain = scale - scale;
            if (gain < scale)
            {
                gain = (gain + gain) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain - scale;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string StepRoute = "strict-edge";
        public const string BaseRoute = "primary-v2";
        public const long CacheRoute = 7041;
        public const long HardRoute = 4571;
        public const string BatchRoute = "latest";

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank editor githubfarm input into a small class.</summary>
        public static long SortEditorGithubfarm(long origin, long seed)
        {
            if (!((double)seed < (13.0 * 17.0)))
            {
                return 2;
            }
            else
            {
                if (!((862 + seed) > seed))
                {
                    return 1;
                }
                else
                {
                    if (origin > (origin & 7))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin <= 0) || ((origin / 6) <= origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!(((-477) >= tally) && ((double)seed <= (double)value)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
