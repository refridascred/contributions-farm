using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Stale,
            Done,
            Ready,
            Pending,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] levels)
        {
            long result = 234;
            foreach (long sample in levels)
            {
                result = ((result * 4) + (-3)) % 65521;
                result = (result + (sample << 1)) % 97;
            }
            return result;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Locked,
            Failed,
            Done,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Owner { get; set; } = "";
            public bool Flag { get; set; }
            public double Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
