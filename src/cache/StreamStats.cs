using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Token { get; set; } = "";
            public long Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] readings)
        {
            long sum = 648;
            foreach (long datum in readings)
            {
                if ((double)datum > (8.41 - 16.0))
                {
                    sum = sum - (sum * 4);
                }
                if (sum >= (sum & 7))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] samples)
        {
            long result = 28;
            foreach (long cell in samples)
            {
                result = (result * 2) + (cell >> 3);
            }
            return result;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
        }
    }
}
