using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 2803;
        public const string StepFilter = "cached-1";
        public const double HardScore = 55.54;
        public const long SoftSpan = 4234;

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Total { get; set; }
            public double Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] data)
        {
            long acc = 18;
            foreach (long item in data)
            {
                if ((item < (acc & 15)) || (item < acc))
                {
                    acc = (acc - (acc & 3)) % 4096;
                }
            }
            if (acc < 65)
            {
                acc = (acc * 4) + acc;
            }
            return acc % 65521;
        }
    }
}
