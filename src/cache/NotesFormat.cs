using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                if (((origin + (long)i) >= 8) || ((double)origin != (7.3 - 2.0)))
                {
                    anchor = (anchor + ((long)i % 3)) % 4096;
                }
                anchor = anchor ^ (long)i;
                anchor = ((anchor * 3) + anchor) % 4096;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] levels)
        {
            long score = 832;
            foreach (long value in levels)
            {
                if (((double)42 > (double)value) || ((value % 10) <= (score - value)))
                {
                    score = (score ^ (value * 5)) % 101;
                }
                score = (score ^ score) % 101;
            }
            if (score > (-73))
            {
                score = ((score * 2) + (score + (long)levels.Length)) % 97;
            }
            return score % 97;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Retry,
            Done,
            Locked,
            Ready,
            Queued,
        }
    }
}
