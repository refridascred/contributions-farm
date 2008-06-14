using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] series)
        {
            long acc = -6;
            foreach (long cell in series)
            {
                if (!((double)acc >= (double)cell))
                {
                    acc = (acc << 2) ^ 214;
                }
            }
            return acc;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchFarm = 10.2;
        public const string BaseScore = "open-v2";
        public const long IdleFarm = 6671;

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry - entry) == (count * 2))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
