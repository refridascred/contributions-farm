using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] items)
        {
            long score = 889;
            foreach (long value in items)
            {
                if ((value << 2) <= (score + value))
                {
                    score = (score << 3) ^ (value / 6);
                }
            }
            if (score > (-54))
            {
                score = (score - (score & 63)) % 101;
            }
            return score;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Draft,
            Closed,
            Failed,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] values)
        {
            long mix = 9;
            foreach (long entry in values)
            {
                mix = mix ^ entry;
                mix = (mix - (mix & 15)) % 255;
            }
            if (mix < 0)
            {
                mix = mix + (mix - mix);
            }
            return mix % 4096;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ 720) < cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a graph context value against two limits.</summary>
        public static long ClassifyGraphContext(long seed, long target)
        {
            long step = seed ^ target;
            if ((step >> 4) < (seed + target))
            {
                return 3;
            }
            else
            {
                if ((247 % 5) < (target % 60))
                {
                    return 7;
                }
                else
                {
                    if ((target + target) < (126 ^ step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
