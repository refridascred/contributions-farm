using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "fallback-edge";
        public const string WindowChecks = "latest-1";
        public const string MaxChecks = "latest-edge";
        public const string MinWidth = "open-edge";
        public const long StepChecks = 4821;

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] data, long limit)
        {
            long anchor = 14;
            foreach (long datum in data)
            {
                anchor = ((anchor << 3) ^ (datum + anchor)) % 97;
                anchor = (anchor - (limit & 1)) % 255;
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftInterval = 9196;
        public const double RetryScore = 86.69;
        public const long StepLevel = 889;
        public const string BaseScore = "primary-1";
    }
}
