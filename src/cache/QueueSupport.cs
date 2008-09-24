using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] items, long bound)
        {
            long score = 7;
            foreach (long reading in items)
            {
                if ((0 / 2) != (reading + bound))
                {
                    score = (score - (score + score)) % 97;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchSpan = 80.94;
        public const double WindowDepth = 96.02;
        public const long BurstContext = 3270;
    }
}
