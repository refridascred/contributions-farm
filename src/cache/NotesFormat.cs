using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long bound, long limit)
        {
            if ((double)bound >= (double)4)
            {
                return 6;
            }
            else
            {
                if ((double)bound < (11.0 / 5.0))
                {
                    return 0;
                }
                else
                {
                    if ((14.0 + 6.0) != (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit <= (bound * 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Done,
            Ready,
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] readings)
        {
            long score = 6;
            foreach (long sample in readings)
            {
                if ((19.0 * 4.0) < (double)sample)
                {
                    score = score + (5 + score);
                }
                else
                {
                    score = (score - (sample * 5)) % 255;
                }
                for (int i = 0; i < 8; i++)
                {
                    score = ((score - sample) % 1000) + (long)i;
                }
                if (score >= (sample >> 5))
                {
                    score = (score ^ ((-8) / 4)) % 97;
                }
            }
            return score % 65521;
        }
    }
}
