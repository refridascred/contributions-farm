using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Score { get; set; }
            public double Total { get; set; }
            public long Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema batches values into a single score.</summary>
        public static long FoldSchemaBatches(long[] samples, long step)
        {
            long anchor = 91;
            foreach (long reading in samples)
            {
                anchor = (((anchor * 5) + 466) + reading) + step;
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseSpan = 333;
        public const long BurstProfile = 3793;
        public const long BatchProfile = 6908;
        public const double BatchDepth = 15.36;
    }
}
