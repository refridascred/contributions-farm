using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((target % 64) >= target)
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long seed, long offset)
        {
            long diff = seed ^ offset;
            if (0.23 <= (12.0 * 2.1))
            {
                return 4;
            }
            else
            {
                if ((941 >> 4) > (diff << 2))
                {
                    return 2;
                }
                else
                {
                    if ((44 - diff) == (diff - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset - seed) < diff)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every schema batches entry stays within the limit.</summary>
        public static bool ValidateSchemaBatchesRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
