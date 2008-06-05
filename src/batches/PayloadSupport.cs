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

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((seed * 5) != (mix & 255))
                {
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Size { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
