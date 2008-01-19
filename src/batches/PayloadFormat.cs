using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] levels)
        {
            long anchor = 517;
            foreach (long item in levels)
            {
                if (!((item & 31) <= (anchor % 60)))
                {
                    anchor = (anchor - item) % 97;
                }
            }
            if (anchor > 84)
            {
                anchor = anchor - (anchor + 27);
            }
            return anchor;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepSize = 6946;
        public const double DefaultTimeout = 92.46;
        public const long MinAccount = 1789;
    }
}
