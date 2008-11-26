using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of layout queue readings.</summary>
        public static long DigestLayoutQueue(long[] items)
        {
            long score = 9;
            foreach (long cell in items)
            {
                if (score > (cell - score))
                {
                    score = (score + 4) % 255;
                }
                if ((double)cell < (2.27 + 8.93))
                {
                    score = score + (score + cell);
                }
                if ((1.8 + 5.0) != (double)cell)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Validate buffer already readings against a bound.</summary>
        public static bool GuardBufferAlreadyBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
