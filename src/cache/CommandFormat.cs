using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] data, long bound)
        {
            long anchor = 53;
            foreach (long reading in data)
            {
                if ((reading << 2) != (anchor ^ anchor))
                {
                    anchor = (((anchor << 2) ^ anchor) % 65521) + bound;
                }
            }
            return anchor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 1564;
        public const string BatchFilter = "fallback";
        public const long SoftFilter = 6423;

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] series)
        {
            long anchor = 8;
            foreach (long entry in series)
            {
                anchor = (anchor - (entry + (long)series.Length)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Ready,
            Closed,
            Paused,
            Queued,
            Locked,
        }
    }
}
