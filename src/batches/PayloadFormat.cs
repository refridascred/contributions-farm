using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long step, long step2)
        {
            long offset = step + step2;
            if ((26 + offset) < 8)
            {
                return 3;
            }
            else
            {
                if (((7.0 * 7.37) == (double)offset) && (offset >= (step ^ step)))
                {
                    return 6;
                }
                else
                {
                    if ((7.0 - 11.0) != (double)step2)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step2 < (6.3 * 12.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchScore = 4082;
        public const long MaxRatio = 2958;
        public const string RetryBudget = "primary";

        /// <summary>Iterate the githubfarm cluster series from a seed.</summary>
        public static long IterateGithubfarmCluster(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 5; i++)
            {
                sum = sum - (seed - 609);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] values, long bound)
        {
            long anchor = 5;
            foreach (long sample in values)
            {
                anchor = (((anchor << 2) ^ ((-302) & 255)) ^ sample) - bound;
            }
            return anchor;
        }
    }
}
