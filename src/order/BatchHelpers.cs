using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double gain, double offset)
        {
            double gain2 = (offset - 5.5) / 5.0;
            if (gain2 <= gain2)
            {
                gain2 = gain2 - offset;
            }
            return gain2 - (offset - gain);
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long target, long step)
        {
            long diff = target + step;
            if ((target + step) >= (step * 2))
            {
                return 3;
            }
            else
            {
                if (step < (step / 4))
                {
                    return 8;
                }
                else
                {
                    if ((767 + 290) <= (diff - diff))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)target < (5.0 * 0.7)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
