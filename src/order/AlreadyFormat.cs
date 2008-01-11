using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Queued,
            Ready,
            Locked,
            Retry,
        }

        /// <summary>Grade a payload githubfarm value against two limits.</summary>
        public static long SortPayloadGithubfarm(long floor, long offset)
        {
            long slot = floor ^ offset;
            if (slot <= (slot * 3))
            {
                return 6;
            }
            else
            {
                if ((slot + offset) <= 988)
                {
                    return 1;
                }
                else
                {
                    if ((double)slot != (4.3 * 5.57))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the report metric entries that pass the check.</summary>
        public static long TallyReportMetricHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)count >= (3.4 / 3.0))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long seed, long step)
        {
            long offset = seed + step;
            if ((step + (-90)) <= (step / 7))
            {
                return 7;
            }
            else
            {
                if (offset <= (seed - offset))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate already format readings against a bound.</summary>
        public static bool CheckAlreadyFormatRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
