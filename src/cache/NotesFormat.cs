using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            Queued,
            Draft,
            Done,
        }
    }
}
