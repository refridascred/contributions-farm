using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Active,
            New,
            Pending,
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowBudget = 4538;
        public const long LimitSchema = 3529;
        public const long StepInterval = 6583;
        public const long BatchSchema = 5108;
        public const long DefaultSchema = 1317;

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 4262;
        public const double HardTimeout = 79.93;
        public const long IdleDepth = 1168;
        public const string MaxTimeout = "strict-v2";
        public const double SoftRecord = 46.03;

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long origin, long floor)
        {
            if (!((floor / 2) <= (origin << 3)))
            {
                return 4;
            }
            else
            {
                if (origin < (origin - origin))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
