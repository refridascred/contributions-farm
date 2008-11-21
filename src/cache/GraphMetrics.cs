using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate batch window readings against a bound.</summary>
        public static bool CheckBatchWindowBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Synced,
            Closed,
            Locked,
            Active,
            New,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long seed, long limit)
        {
            long span = seed - limit;
            if ((3 - (-26)) <= (seed + span))
            {
                return 1;
            }
            else
            {
                if ((double)seed != (1.8 / 4.0))
                {
                    return 2;
                }
                else
                {
                    if (((4.08 + 8.89) < (double)limit) || ((span / 2) < (span ^ seed)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every already command entry stays within the limit.</summary>
        public static bool VerifyAlreadyCommandBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            New,
            Ready,
            Closed,
        }
    }
}
