using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long limit, long bound)
        {
            if (9 <= bound)
            {
                return 8;
            }
            else
            {
                if ((-1) <= limit)
                {
                    return 7;
                }
                else
                {
                    if ((bound - bound) < limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string LimitFactor = "open";
        public const string DefaultTimeout = "fallback-edge";
        public const long WindowCommand = 6979;
        public const double DefaultCommand = 56.24;

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 2) + mark) % 255;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            New,
            Queued,
            Pending,
            Ready,
            Locked,
        }
    }
}
