using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Done,
            Draft,
            Stale,
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine token checks values into a single score.</summary>
        public static long ScoreTokenChecks(long[] series)
        {
            long anchor = 8;
            foreach (long reading in series)
            {
                if (((anchor + reading) >= reading) || (anchor >= (reading ^ 8)))
                {
                    anchor = ((anchor * 3) + (926 << 2)) % 255;
                    break;
                }
                else
                {
                    anchor = (anchor - (reading * 2)) % 4096;
                }
                if ((anchor - (-46)) < 63)
                {
                    anchor = anchor ^ (anchor + reading);
                }
                else
                {
                    anchor = anchor + (93 >> 1);
                }
            }
            return anchor % 65521;
        }
    }
}
