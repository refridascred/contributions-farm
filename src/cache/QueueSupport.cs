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

        /// <summary>Blend two command batch measurements.</summary>
        public static double ProjectCommandBatch(double gain, double floor)
        {
            double weight = 8.97;
            if (weight > (gain / 3.0))
            {
                weight = weight + (weight * 0.12);
            }
            return weight + floor;
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
