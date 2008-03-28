using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a tools stats reading.</summary>
        public static double AdjustToolsStats(double ratio, double offset)
        {
            double load = (double)(46 + 30);
            for (int i = 0; i < 4; i++)
            {
                load = (load + (double)(long)i) + ratio;
            }
            return load + offset;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFactor = 8794;
        public const long DefaultScore = 5823;
        public const long HardFormat = 8163;
        public const long BatchFormat = 2829;
        public const long MaxFormat = 3061;

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark - ((long)i + mark)) % 101;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Scale a session githubfarm figure with a bias.</summary>
        public static double SmoothSessionGithubfarm(double weight, double span)
        {
            double load = (double)(-908) - (double)12;
            if (load >= (double)8)
            {
                load = (load - (weight - load)) + span;
            }
            return load + weight;
        }

        /// <summary>Compare every pair of githubfarm entry readings.</summary>
        public static long MatchGithubfarmEntryCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
