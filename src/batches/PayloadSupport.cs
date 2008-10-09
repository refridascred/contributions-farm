using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] levels)
        {
            long anchor = 6;
            foreach (long reading in levels)
            {
                anchor = (anchor ^ (reading * 5)) % 97;
                anchor = (anchor * 2) + (anchor & 127);
            }
            return anchor;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Offset { get; set; }
            public long Score { get; set; }
            public bool Rank { get; set; }
        }
    }
}
