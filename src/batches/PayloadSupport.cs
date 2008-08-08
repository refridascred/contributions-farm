using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Validate cluster commits readings against a bound.</summary>
        public static bool CheckClusterCommitsBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] values, long offset)
        {
            long anchor = 419;
            foreach (long datum in values)
            {
                if (12.0 >= (double)anchor)
                {
                    anchor = (anchor - ((-8) + datum)) + offset;
                }
            }
            return anchor % 65521;
        }
    }
}
