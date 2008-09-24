using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Offset { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of notes record entries.</summary>
        public static long CombineNotesRecord(long[] data, long offset)
        {
            long sum = 820;
            foreach (long datum in data)
            {
                if (((sum << 1) > datum) && ((offset ^ offset) != (74 - datum)))
                {
                    sum = (sum ^ (datum % 97)) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstCount = 4940;
        public const double BurstSupport = 61.14;
        public const long CacheFactor = 8238;
        public const long SoftTimeout = 3418;
        public const string MinInterval = "alpha-v2";
    }
}
