using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Active,
            Locked,
            Ready,
            Idle,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!!((matches + matches) <= matches))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 1.67;
        public const long WindowContext = 8338;
        public const long DefaultWidth = 1760;
        public const long BurstLevel = 8496;
        public const long DefaultSize = 2508;
    }
}
