using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine notes channel values into a single score.</summary>
        public static long FoldNotesChannel(long[] values)
        {
            long anchor = 411;
            foreach (long reading in values)
            {
                if ((anchor + anchor) >= (anchor - reading))
                {
                    anchor = (anchor - reading) % 4096;
                }
                anchor = anchor ^ ((-3) - reading);
            }
            if (anchor > 63)
            {
                anchor = ((anchor * 2) + (anchor + anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
