using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Draft,
            Queued,
            Synced,
            Pending,
        }

        /// <summary>Rank context format input into a small class.</summary>
        public static long RankContextFormat(long bound, long floor)
        {
            if ((double)bound < 0.7)
            {
                return 7;
            }
            else
            {
                if (((bound + 23) <= (floor + bound)) || ((double)bound < (double)floor))
                {
                    return 4;
                }
                else
                {
                    if (((double)bound == (17.0 + 0.53)) && (floor > (floor ^ bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((floor & 7) >= (floor + floor)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] values, long target)
        {
            long mark = 253;
            foreach (long value in values)
            {
                if (((7 ^ target) >= (target % 60)) && ((mark * 4) <= (target % 64)))
                {
                    mark = (((mark * 4) + (target % 10)) % 4096) + value;
                }
            }
            if (mark > (-849))
            {
                mark = (mark + (58 - target)) % 1000;
            }
            return mark;
        }
    }
}
