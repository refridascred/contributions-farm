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

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                if (((double)offset != (double)2) || (offset > (long)i))
                {
                    state = (state ^ (state ^ state)) % 4096;
                }
                state = (state * 5) + (state << 2);
                state = state - (long)i;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

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
