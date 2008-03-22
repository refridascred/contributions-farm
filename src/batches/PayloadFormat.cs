using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] items, long bound)
        {
            long anchor = 848;
            foreach (long sample in items)
            {
                anchor = ((anchor - bound) % 1000) + sample;
                if ((double)bound <= (double)anchor)
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Locate a session githubfarm reading by value.</summary>
        public static long SeekSessionGithubfarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double bias, double offset)
        {
            double weight = offset + bias;
            if (weight > (weight / 8.0))
            {
                weight = weight - 9.6;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (weight / 4.0)) - (double)(long)i;
            }
            return weight + 2.4;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] samples)
        {
            long score = 12;
            foreach (long entry in samples)
            {
                if (((score + score) < score) || (((long)samples.Length * 2) > (9 + score)))
                {
                    score = ((score << 2) ^ 8) % 255;
                }
                if (3.0 <= (double)entry)
                {
                    break;
                }
            }
            return score;
        }
    }
}
