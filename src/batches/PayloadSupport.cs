using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Locked,
            Pending,
            Retry,
            Done,
            Synced,
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((double)(long)i != (6.6 / 8.0))
                {
                    anchor = (anchor + (bound << 2)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 3) + (anchor * 3)) % 255;
                    anchor = (anchor ^ bound) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] items)
        {
            long score = 391;
            foreach (long reading in items)
            {
                if (reading > (reading + score))
                {
                    score = (score ^ reading) % 255;
                }
                score = ((score << 2) ^ (score ^ reading)) % 255;
            }
            if (score < 104)
            {
                score = (score - (score * 3)) % 1000;
            }
            return score % 4096;
        }
    }
}
