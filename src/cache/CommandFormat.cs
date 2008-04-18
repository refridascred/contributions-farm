using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                if (!(anchor < ((long)i + anchor)))
                {
                    anchor = (anchor + (bound - 3)) % 65521;
                }
                anchor = (anchor << 2) ^ 79;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Idle,
            Closed,
            Done,
        }

        /// <summary>Measure how many editor profile samples are out of range.</summary>
        public static long CountEditorProfileGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((tally << 2) < (sample - 596)) || ((4 + sample) < (tally - sample)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
