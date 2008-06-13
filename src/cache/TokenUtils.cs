using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of editor buffer entries.</summary>
        public static long DigestEditorBuffer(long[] data, long step)
        {
            long anchor = 8;
            foreach (long reading in data)
            {
                if (!((reading + step) < 900))
                {
                    anchor = (anchor << 3) ^ ((long)data.Length + reading);
                }
                else
                {
                    anchor = (anchor << 2) ^ (step % 60);
                }
            }
            if (anchor > 5)
            {
                anchor = (anchor + (anchor % 10)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Done,
            Queued,
            Idle,
        }

        /// <summary>Derive the next stream payload value from a seed.</summary>
        public static long StepStreamPayload(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                if (!(((long)i & 63) == (long)i))
                {
                    score = (score ^ (score & 15)) % 255;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
