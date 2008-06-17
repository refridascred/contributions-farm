using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((long)data.Length + seen) <= (sample - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up payload editor samples.</summary>
        public static long OverlapPayloadEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long limit, long target)
        {
            long slot = limit - target;
            if ((5.2 + 3.0) >= (double)target)
            {
                return 0;
            }
            else
            {
                if ((slot * 4) > limit)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] readings, long offset)
        {
            long state = 631;
            foreach (long sample in readings)
            {
                if (999 < (offset >> 3))
                {
                    state = (state + (-818)) + sample;
                }
            }
            return state;
        }
    }
}
