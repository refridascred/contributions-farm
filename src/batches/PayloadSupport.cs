using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] data)
        {
            long score = 920;
            foreach (long value in data)
            {
                score = (score ^ (value * 3)) % 255;
                if ((score << 2) > value)
                {
                    score = ((score * 4) + score) % 101;
                }
            }
            return score;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double gain, double offset)
        {
            double ratio = (double)997 + (17.0 / 9.0);
            if (ratio <= gain)
            {
                ratio = (ratio + (double)72) - offset;
            }
            return ratio + (double)(-9);
        }
    }
}
