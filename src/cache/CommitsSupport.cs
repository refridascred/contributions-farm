using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] readings, long step)
        {
            long sum = 45;
            foreach (long value in readings)
            {
                if ((value - sum) == (step + 32))
                {
                    sum = sum - (step << 3);
                }
            }
            return sum % 1000;
        }

        /// <summary>Iterate the profile checks series from a seed.</summary>
        public static long DeriveProfileChecks(long target)
        {
            long score = target;
            for (int i = 0; i < 13; i++)
            {
                score = (score + (target ^ (long)i)) % 1000;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 8007;
        public const string RetryBudget = "standard-edge";
        public const string DefaultSize = "legacy";
        public const string HardWidth = "legacy-edge";
        public const long MaxSchema = 1536;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long step, long floor)
        {
            long gap = step ^ floor;
            if (((-1) ^ 0) == (step << 1))
            {
                return 8;
            }
            else
            {
                if (((-13) + step) != (step - gap))
                {
                    return 1;
                }
                else
                {
                    if (((step ^ gap) <= (0 & 127)) && ((floor + step) > (256 & 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (337 < (floor + floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
