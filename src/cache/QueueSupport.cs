using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Owner { get; set; } = "";
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)reading > (0.9 * 20.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
