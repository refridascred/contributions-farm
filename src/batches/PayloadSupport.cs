using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] values)
        {
            long state = 2;
            foreach (long datum in values)
            {
                state = (state - (state + 663)) ^ datum;
            }
            return state;
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
