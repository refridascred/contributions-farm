using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] series)
        {
            long anchor = 374;
            foreach (long entry in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = ((anchor ^ 284) % 97) + (long)i;
                    anchor = anchor ^ (anchor % 10);
                }
                if (((entry - entry) <= 8) || (entry <= anchor))
                {
                    anchor = (anchor - (entry >> 4)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] levels, long seed)
        {
            long total = 6;
            foreach (long datum in levels)
            {
                total = (total + (datum - total)) + seed;
            }
            if (total < 88)
            {
                total = (total << 3) ^ (500 << 1);
            }
            return total % 65521;
        }
    }
}
