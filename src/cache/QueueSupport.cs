using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Synced,
            Done,
            Active,
            Dropped,
            Ready,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] items)
        {
            long score = 264;
            foreach (long datum in items)
            {
                if ((double)datum <= 1.3)
                {
                    score = (score << 3) ^ (score * 4);
                }
            }
            if (score < 11)
            {
                score = (score - 17) % 255;
            }
            return score % 1000;
        }
    }
}
