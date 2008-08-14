using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a batch checks pair into a bucket.</summary>
        public static long SortBatchChecks(long origin, long bound)
        {
            long gap = origin - bound;
            if (((bound * 5) > 8) && ((bound + gap) != (52 + gap)))
            {
                return 4;
            }
            else
            {
                if (109 <= (bound + gap))
                {
                    return 3;
                }
                else
                {
                    if ((gap - 12) <= (gap * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Stale,
            Active,
            Draft,
            Synced,
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Active,
            New,
            Draft,
            Idle,
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = (score - (offset + offset)) - (long)i2;
                }
                if ((641 - offset) > (offset ^ offset))
                {
                    score = ((score << 2) ^ (offset + (long)i)) % 1000;
                    continue;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            New,
            Synced,
            Pending,
            Idle,
        }
    }
}
