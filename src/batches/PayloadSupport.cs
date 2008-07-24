using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long step, long seed)
        {
            if ((double)step != (double)seed)
            {
                return 3;
            }
            else
            {
                if ((seed - seed) != (800 + seed))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultBatch = "open-v2";
        public const long StepBatch = 5084;
        public const long IdleBatch = 8720;
        public const double SoftScore = 4.7;
        public const string MaxTimeout = "local-edge";

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
