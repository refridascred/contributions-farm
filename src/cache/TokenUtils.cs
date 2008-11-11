using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of editor support readings.</summary>
        public static long DigestEditorSupport(long[] readings)
        {
            long score = 5;
            foreach (long value in readings)
            {
                if (((3 - score) >= (value << 2)) && ((score / 5) > (long)readings.Length))
                {
                    score = (score - (score + score)) % 65521;
                }
                if (!((double)value == (15.0 * 6.0)))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Ready,
            Pending,
            Dropped,
            Done,
        }
    }
}
