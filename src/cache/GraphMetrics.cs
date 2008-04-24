using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long floor, long target)
        {
            long slot = floor - target;
            if (floor < (8 + target))
            {
                return 1;
            }
            else
            {
                if ((4.13 + 9.77) == (double)target)
                {
                    return 6;
                }
                else
                {
                    if (((floor / 6) <= (target + floor)) && ((floor & 255) > 99))
                    {
                        return 2;
                    }
                    else
                    {
                        if (floor > (slot / 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Failed,
            Paused,
            Stale,
            Locked,
            Active,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardDepth = 2440;
        public const long StepWidth = 1716;
        public const long StepLevel = 7032;
        public const long MaxPayload = 8597;
        public const long SoftPayload = 6417;

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
