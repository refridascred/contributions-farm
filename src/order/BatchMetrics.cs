using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long bound, long origin)
        {
            if (((double)bound > (3.0 / 2.0)) && ((origin + 44) >= (93 % 3)))
            {
                return 4;
            }
            else
            {
                if (origin >= (943 + bound))
                {
                    return 5;
                }
                else
                {
                    if ((origin & 127) >= (origin ^ origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound + 271) < origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc << 3) ^ (target % 16);
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = ((acc + ((long)i + 13)) % 1000) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MaxScore = 88.75;
        public const long HardRatio = 6656;
        public const long StepDepth = 7500;

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long step, long bound)
        {
            if (!((step / 6) != (bound + bound)))
            {
                return 2;
            }
            else
            {
                if ((228 <= (step << 2)) && ((bound / 5) > step))
                {
                    return 1;
                }
                else
                {
                    if ((bound >> 5) <= step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Idle,
            Stale,
            Active,
        }
    }
}
