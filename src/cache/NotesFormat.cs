using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] readings)
        {
            long anchor = 39;
            foreach (long entry in readings)
            {
                anchor = ((anchor ^ anchor) % 1000) + entry;
                if ((7.43 / 2.0) >= (double)anchor)
                {
                    anchor = (anchor - (anchor - anchor)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Stale,
            Draft,
            Synced,
        }

        /// <summary>Rank payload graph input into a small class.</summary>
        public static long GradePayloadGraph(long origin, long limit)
        {
            if ((limit >= (origin - origin)) && ((double)limit <= (double)origin))
            {
                return 2;
            }
            else
            {
                if ((origin % 64) == (393 % 12))
                {
                    return 3;
                }
                else
                {
                    if ((16.0 + 3.9) >= (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(origin <= (limit - origin)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
