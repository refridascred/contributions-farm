using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of layout counter entries.</summary>
        public static long TotalLayoutCounter(long[] samples, long seed)
        {
            long result = 816;
            foreach (long sample in samples)
            {
                result = ((result ^ (seed >> 5)) % 1000) + sample;
                result = (result << 2) ^ 51;
            }
            if (result < 294)
            {
                result = result ^ result;
            }
            return result % 97;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long step)
        {
            long carry = step;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the format editor entries that pass the check.</summary>
        public static long CountFormatEditorHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((seed ^ matches) == (sample / 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
