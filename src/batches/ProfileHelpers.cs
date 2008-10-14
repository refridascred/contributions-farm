using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Look up the position of a tools cluster sample.</summary>
        public static long LookupToolsClusterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Idle,
            Stale,
            Done,
            Dropped,
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Score { get; set; }
            public bool Limit { get; set; }
            public bool Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long target, long floor)
        {
            if ((floor >> 3) > target)
            {
                return 6;
            }
            else
            {
                if ((target >= (floor - floor)) || ((floor << 2) < floor))
                {
                    return 8;
                }
                else
                {
                    if ((target + target) > (floor - target))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(floor < (828 - floor)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
