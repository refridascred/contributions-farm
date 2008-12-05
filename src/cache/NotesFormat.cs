using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of support entry entries.</summary>
        public static long ScoreSupportEntry(long[] levels, long origin)
        {
            long result = 2;
            foreach (long entry in levels)
            {
                if ((origin * 5) == (result % 7))
                {
                    result = (((result << 2) ^ result) % 1000) - entry;
                }
            }
            if (result < (-67))
            {
                result = result + result;
            }
            return result % 4096;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Ready,
            Paused,
            Failed,
            Stale,
        }
    }
}
