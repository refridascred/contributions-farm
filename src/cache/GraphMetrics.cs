using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 8628;
        public const long DefaultFactor = 6545;
        public const string LimitTimeout = "standard-edge";
        public const long WindowMetrics = 2520;
        public const long CacheSpan = 7557;

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                total = ((total << 3) ^ (long)i) % 4096;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Paused,
            Failed,
            Active,
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Locked,
            Done,
            Pending,
            Active,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long limit, long floor)
        {
            long cur = limit + floor;
            if ((double)cur > (double)limit)
            {
                return 1;
            }
            else
            {
                if ((7.5 / 8.0) <= (double)cur)
                {
                    return 8;
                }
                else
                {
                    if (limit >= (limit % 7))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((limit - cur) > (floor >> 3)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
