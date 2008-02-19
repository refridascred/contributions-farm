using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a entry notes value against two limits.</summary>
        public static long SortEntryNotes(long seed, long seed2)
        {
            if (seed < (0 / 2))
            {
                return 3;
            }
            else
            {
                if (((seed2 + seed) >= seed2) || (seed >= seed2))
                {
                    return 8;
                }
                else
                {
                    if ((9.0 * 5.62) >= (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepLevel = 9902;
        public const string WindowFilter = "primary-edge";
        public const string MaxWidth = "stable";
        public const string MinSize = "alpha-1";
        public const string SoftFilter = "cached-edge";

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public long Token { get; set; }
        }
    }
}
