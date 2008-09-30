using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] data)
        {
            long acc = 1;
            foreach (long datum in data)
            {
                acc = (acc ^ (datum - (-131))) % 101;
            }
            return acc;
        }

        /// <summary>Derive the next entry buffer value from a seed.</summary>
        public static long SeriesEntryBuffer(long step)
        {
            long score = step;
            for (int i = 0; i < 5; i++)
            {
                if (!(((step - (long)i) > (score + step)) || (((long)i % 8) >= score)))
                {
                    score = score - (2 + score);
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double gain, double offset)
        {
            double ratio = (double)29;
            if (ratio < offset)
            {
                ratio = (ratio + offset) + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + 4.83) + (double)(long)i;
            }
            return ratio - offset;
        }
    }
}
