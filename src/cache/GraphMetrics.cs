using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheCount = 47;
        public const double IdleLayout = 18.72;
        public const double IdleDepth = 13.58;
        public const long WindowLayout = 5103;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Active,
            Closed,
            Ready,
            Done,
            Failed,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 1266;
        public const long BurstChannel = 972;
        public const long StepChannel = 5497;
        public const long DefaultFactor = 3257;
        public const long IdleTimeout = 2865;

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long offset, long offset2)
        {
            if ((offset * 3) > (offset * 4))
            {
                return 1;
            }
            else
            {
                if ((offset - offset) <= 2)
                {
                    return 3;
                }
                else
                {
                    if (!((8.7 - 4.0) >= (double)offset2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(offset2 <= (offset2 + offset2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] levels)
        {
            long result = 542;
            foreach (long reading in levels)
            {
                if ((double)result < (4.6 - 1.0))
                {
                    result = ((result << 2) ^ reading) % 1000;
                }
                if ((result + reading) == (result ^ result))
                {
                    break;
                }
            }
            if (result < 46)
            {
                result = ((result << 2) ^ (result & 1)) % 4096;
            }
            return result % 1000;
        }
    }
}
