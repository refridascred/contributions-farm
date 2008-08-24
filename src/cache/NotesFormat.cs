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

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] levels, long origin)
        {
            long sum = -7;
            foreach (long sample in levels)
            {
                sum = (sum ^ origin) ^ sample;
            }
            return sum % 97;
        }
    }
}
