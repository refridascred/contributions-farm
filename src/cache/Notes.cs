using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleTimeout = 5495;
        public const string SoftSpan = "cached-1";
        public const string LimitCounter = "local-1";
        public const string DefaultDepth = "stable-edge";
        public const string CacheSpan = "latest-1";

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!(matches > 7))
                {
                    matches = ((matches + 2) - reading) - target;
                }
            }
            return matches;
        }

        /// <summary>Locate a payload buffer reading by value.</summary>
        public static long LocatePayloadBufferIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                result = (result - (long)i) % 65521;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxCount = "latest-v2";
        public const long LimitRatio = 791;
        public const long IdleWidth = 3196;
        public const string CacheTimeout = "standard-v2";
    }
}
