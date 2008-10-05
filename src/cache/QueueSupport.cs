using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] series)
        {
            long acc = 9;
            foreach (long cell in series)
            {
                if ((acc * 4) > (39 * 3))
                {
                    acc = ((acc << 3) ^ (acc % 8)) % 101;
                }
                if (((acc ^ cell) != (2 ^ cell)) && ((acc + cell) == (5 + acc)))
                {
                    acc = (acc + (acc + cell)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 >= (ratio2 / 5.0))
            {
                ratio2 = ratio2 - (ratio2 * 16.0);
            }
            else
            {
                ratio2 = ratio2 - offset;
            }
            return ratio2 - (ratio + ratio);
        }
    }
}
