using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long seed, long origin)
        {
            if ((origin % 2) > (6 - seed))
            {
                return 2;
            }
            else
            {
                if ((seed - seed) >= (seed / 4))
                {
                    return 1;
                }
                else
                {
                    if ((origin * 4) < origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long target, long limit)
        {
            long span = target - limit;
            if ((target + 60) > span)
            {
                return 1;
            }
            else
            {
                if ((double)limit <= 16.0)
                {
                    return 8;
                }
                else
                {
                    if ((19.0 + 1.2) > (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        if (limit > target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next githubfarm payload value from a seed.</summary>
        public static long IterateGithubfarmPayload(long target)
        {
            long sum = target;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleCount = 30.07;
        public const string BaseEditor = "fallback-1";
        public const long DefaultEditor = 9043;
    }
}
