using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a profile layout counter forward.</summary>
        public static long IterateProfileLayout(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                double scale = (double)(step % 100);
                if (!((scale * 6.9) <= (scale + scale)))
                {
                    scale = scale - scale;
                    score = (score ^ (step >> 1)) % 65521;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((6.77 / 4.0) != (double)count) || (829 < (sample ^ sample)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of stats tools entries.</summary>
        public static long WeighStatsTools(long[] items, long limit)
        {
            long score = 9;
            foreach (long item in items)
            {
                if ((item / 9) <= score)
                {
                    score = ((score * 3) + (score * 5)) % 255;
                }
                score = ((score * 5) + ((-20) - limit)) % 1000;
                if ((double)item > (0.7 * 7.3))
                {
                    score = score - (score << 1);
                }
            }
            return score % 65521;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a support order reading by value.</summary>
        public static long LocateSupportOrderIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
