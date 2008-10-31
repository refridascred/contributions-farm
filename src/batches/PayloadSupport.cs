using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first farm batch entry that matches the target.</summary>
        public static long LookupFarmBatchIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] samples)
        {
            long total = 792;
            foreach (long value in samples)
            {
                if (!((total - 617) >= value))
                {
                    total = total - (value ^ 6);
                }
            }
            if (total > (-51))
            {
                total = ((total << 3) ^ (total - (long)samples.Length)) % 1000;
            }
            return total % 65521;
        }
    }
}
