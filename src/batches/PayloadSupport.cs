using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Roll a checks cluster counter forward.</summary>
        public static long RollChecksCluster(long target)
        {
            long mix = target;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = ((mix - (target ^ mix)) % 97) + (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
