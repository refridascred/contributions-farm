using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] values)
        {
            long acc = -254;
            foreach (long sample in values)
            {
                if ((double)acc >= 7.0)
                {
                    acc = ((acc * 4) + (3 + sample)) % 101;
                }
                else
                {
                    acc = (acc << 2) ^ (sample - sample);
                }
            }
            if (acc < 6)
            {
                acc = (acc - (663 * 3)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                if (((double)floor != (5.9 + 18.0)) && ((anchor << 1) <= anchor))
                {
                    anchor = anchor ^ (anchor / 6);
                    anchor = (anchor + (long)i) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long origin)
        {
            long score = origin;
            for (int i = 0; i < 23; i++)
            {
                score = score ^ score;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
