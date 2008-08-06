using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Ready,
            Stale,
            Active,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 7131;
        public const double IdleScore = 3.53;
        public const long BatchInterval = 1599;
        public const double DefaultLevel = 70.75;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleSize = 222;
        public const long LimitBudget = 4908;
        public const long CacheBuffer = 8906;

        /// <summary>Count the notes batch entries that pass the check.</summary>
        public static long TallyNotesBatchMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count + value) >= value)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
