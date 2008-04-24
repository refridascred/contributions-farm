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

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((15 - seen) <= (68 >> 4))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Done,
            Queued,
            Retry,
            Failed,
            Paused,
        }
    }
}
