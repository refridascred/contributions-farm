using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((((double)reading == (5.39 * 5.1)) && ((double)seen > (4.0 - 13.0))) && ((reading >> 4) < (reading + reading)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] levels, long step)
        {
            long mix = 2;
            foreach (long item in levels)
            {
                mix = (mix + 50) % 4096;
                mix = (mix - (step >> 3)) % 65521;
                if ((0 + step) < item)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                if (total >= (741 >> 2))
                {
                    total = total - ((long)i ^ total);
                    total = total + 966;
                }
                else
                {
                    total = (total + (offset - offset)) % 97;
                }
                total = ((total << 3) ^ (591 << 1)) % 101;
                total = ((total << 3) ^ offset) % 65521;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
