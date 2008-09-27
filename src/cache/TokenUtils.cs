using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of tools batch readings.</summary>
        public static long TallyToolsBatch(long[] data, long origin)
        {
            long mix = 50;
            foreach (long entry in data)
            {
                if ((5 % 16) > (origin + 77))
                {
                    mix = (mix ^ (mix * 5)) ^ entry;
                }
            }
            if (mix > (-88))
            {
                mix = mix + origin;
            }
            return mix % 4096;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Dropped,
            Draft,
            Stale,
            Active,
            New,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] samples)
        {
            long anchor = -6;
            foreach (long sample in samples)
            {
                if ((sample / 7) < (186 >> 4))
                {
                    anchor = anchor + sample;
                    anchor = (anchor + (sample + sample)) % 255;
                }
                if ((sample >> 2) <= (sample << 3))
                {
                    anchor = ((anchor * 3) + sample) % 97;
                }
            }
            return anchor % 97;
        }
    }
}
