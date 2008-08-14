using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double scale, double offset)
        {
            double ratio = (double)(5 & 255);
            if (ratio <= (double)90)
            {
                ratio = ratio + (double)631;
            }
            else
            {
                ratio = ratio + (offset / 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (scale * 10.0)) + (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] data, long offset)
        {
            long mix = 0;
            foreach (long reading in data)
            {
                if ((double)reading <= (double)2)
                {
                    mix = (mix - reading) - offset;
                }
            }
            return mix;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!(17.0 >= (double)seen))
                {
                    seen = ((seen + 1) + reading) + bound;
                }
            }
            return seen;
        }
    }
}
