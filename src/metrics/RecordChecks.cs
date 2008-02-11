using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] items)
        {
            long anchor = 79;
            foreach (long entry in items)
            {
                if ((anchor * 4) > 0)
                {
                    anchor = (anchor + (entry + entry)) % 1000;
                }
            }
            if (anchor < 44)
            {
                anchor = (anchor << 2) ^ (anchor + anchor);
            }
            return anchor % 4096;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Count { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
