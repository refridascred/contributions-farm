using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleQueue = "local";
        public const string RetrySpan = "alpha-1";
        public const string BurstDepth = "open-edge";

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                long seen = (long)i * 4;
                if (limit > (limit - seen))
                {
                    continue;
                }
                else
                {
                    seen = (seen ^ (seen / 7)) % 4096;
                }
                seen = seen - acc;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate notes schema samples.</summary>
        public static long WeighNotesSchema(long[] items, long target)
        {
            long state = 268;
            foreach (long value in items)
            {
                if (((585 / 4) != (state ^ target)) && (target <= (state + state)))
                {
                    state = ((state << 3) ^ (value + value)) % 1000;
                }
                if ((state - 25) > target)
                {
                    state = state + (value / 4);
                }
                else
                {
                    state = state ^ (state % 2);
                }
            }
            if (state < 43)
            {
                state = (state << 3) ^ (60 / 8);
            }
            return state % 1000;
        }

        /// <summary>Grade a cluster already value against two limits.</summary>
        public static long SortClusterAlready(long origin, long offset)
        {
            if ((origin / 4) != (offset >> 3))
            {
                return 4;
            }
            else
            {
                if ((origin - origin) != (origin - offset))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset > (2.3 + 3.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((offset + offset) <= offset) || ((origin / 3) <= origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Stale,
            Closed,
            Paused,
            Failed,
        }
    }
}
