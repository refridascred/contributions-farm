using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks command samples are out of range.</summary>
        public static long CountChecksCommandMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((seen - seen) > (seen / 9)) || (((4.71 + 1.5) < (double)step) || ((double)9 >= (double)step)))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
