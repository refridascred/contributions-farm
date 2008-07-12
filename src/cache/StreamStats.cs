using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Draft,
            Paused,
            Stale,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Stamp { get; set; }
            public long Label { get; set; }
            public string Owner { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] samples)
        {
            long mark = 750;
            foreach (long reading in samples)
            {
                if ((reading >> 2) <= (reading % 16))
                {
                    mark = (mark - (reading + reading)) % 101;
                }
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of already batch readings.</summary>
        public static long WeighAlreadyBatch(long[] levels, long bound)
        {
            long acc = 7;
            foreach (long entry in levels)
            {
                acc = (((acc * 2) + (acc - 825)) + entry) - bound;
            }
            return acc % 97;
        }
    }
}
