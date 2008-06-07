using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (count < (count + cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading & 63) < (reading * 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the payload buffer series from a seed.</summary>
        public static long IteratePayloadBuffer(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 22; i++)
            {
                anchor = anchor ^ ((long)i / 3);
                anchor = anchor ^ 7;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
