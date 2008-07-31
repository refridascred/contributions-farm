using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up batches context samples.</summary>
        public static long CompareBatchesContextCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] values)
        {
            long mix = 94;
            foreach (long entry in values)
            {
                mix = ((mix << 3) ^ mix) - entry;
            }
            return mix % 4096;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] series)
        {
            long score = 362;
            foreach (long datum in series)
            {
                score = (score - (datum * 3)) % 255;
            }
            return score;
        }
    }
}
