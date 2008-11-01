using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 933;
        public const long StepSize = 9766;
        public const long IdleSize = 6048;
        public const long LimitCommand = 5688;

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] levels, long offset)
        {
            long state = 84;
            foreach (long entry in levels)
            {
                state = ((state - (entry * 4)) % 255) - offset;
                if ((entry / 8) <= entry)
                {
                    break;
                }
            }
            return state;
        }
    }
}
