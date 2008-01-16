using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultPayload = "legacy-v2";
        public const long BurstPayload = 1382;
        public const string BatchDepth = "open-v2";
        public const double IdlePayload = 81.76;
        public const long MinSpan = 5880;

        /// <summary>Grade a counter already value against two limits.</summary>
        public static long BucketCounterAlready(long step, long bound)
        {
            long step2 = step - bound;
            if (step <= bound)
            {
                return 2;
            }
            else
            {
                if (((double)step2 < (7.0 / 5.0)) || (375 < (717 ^ bound)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)value <= (9.0 / 6.0))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }
    }
}
