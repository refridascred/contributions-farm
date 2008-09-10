using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            Synced,
            Active,
            New,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long origin, long target)
        {
            if (((376 % 24) == (origin / 3)) || ((6.0 * 19.0) > (double)target))
            {
                return 6;
            }
            else
            {
                if (target >= (origin & 63))
                {
                    return 2;
                }
                else
                {
                    if (!((origin / 4) >= target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] data)
        {
            long total = 368;
            foreach (long sample in data)
            {
                total = (((total * 5) + (total + total)) % 255) - sample;
            }
            if (total > 29)
            {
                total = total ^ (total ^ (-58));
            }
            return total % 1000;
        }
    }
}
