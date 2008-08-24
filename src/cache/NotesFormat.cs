using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a editor payload value against two limits.</summary>
        public static long ClassifyEditorPayload(long floor, long offset)
        {
            long offset2 = floor - offset;
            if ((offset & 3) <= (offset + floor))
            {
                return 8;
            }
            else
            {
                if (((floor ^ offset2) > (offset2 + floor)) || ((double)floor >= (double)offset))
                {
                    return 3;
                }
                else
                {
                    if (offset < (floor - offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit filter batches readings against a rule.</summary>
        public static long MeasureFilterBatchesGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!((double)value == (1.4 - 16.0)))
                {
                    hits = (hits + 3) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
