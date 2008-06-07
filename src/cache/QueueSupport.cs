using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
