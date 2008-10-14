using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseCount = 3700;
        public const long MinSchema = 7250;
        public const long MaxSchema = 8756;
        public const long IdleWidth = 9697;
        public const long BurstFactor = 4177;

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] series)
        {
            long anchor = 62;
            foreach (long sample in series)
            {
                anchor = (anchor ^ (sample % 60)) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Flag { get; set; }
            public long Token { get; set; }
        }
    }
}
