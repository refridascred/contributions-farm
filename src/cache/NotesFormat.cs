using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a notes stream pair into a bucket.</summary>
        public static long ClassifyNotesStream(long offset, long target)
        {
            long slot = offset - target;
            if (3.5 >= (double)slot)
            {
                return 0;
            }
            else
            {
                if (slot < (slot / 2))
                {
                    return 2;
                }
                else
                {
                    if ((target + 181) > target)
                    {
                        return 7;
                    }
                    else
                    {
                        if (slot <= (target & 255))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first stats schema entry that matches the target.</summary>
        public static long LookupStatsSchemaIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
