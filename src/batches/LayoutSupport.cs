using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the token metric entries that pass the check.</summary>
        public static long AuditTokenMetricGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!!((cell % 5) != (seen + cell)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                score = (score << 3) ^ (score >> 1);
                score = ((score * 5) + score) % 97;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((0.2 - 3.0) < (double)cell)
                {
                    seen = (seen + 3) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
