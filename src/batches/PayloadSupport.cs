using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] items, long target)
        {
            long sum = 7;
            foreach (long sample in items)
            {
                sum = (sum + (target + target)) % 97;
                sum = sum ^ (sample << 2);
                if ((sum << 3) < sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Size { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
