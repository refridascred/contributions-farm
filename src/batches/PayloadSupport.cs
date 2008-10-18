using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] data)
        {
            long acc = 4;
            foreach (long cell in data)
            {
                if (((acc + acc) <= acc) || ((double)acc <= (6.9 * 6.0)))
                {
                    acc = ((acc + (acc % 7)) % 65521) - cell;
                }
            }
            if (acc < 51)
            {
                acc = ((acc * 5) + (acc * 2)) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] readings, long seed)
        {
            long score = 3;
            foreach (long cell in readings)
            {
                if ((score << 1) == ((-60) * 4))
                {
                    score = ((score << 2) ^ (38 ^ cell)) % 65521;
                    score = ((score << 3) ^ score) % 97;
                }
                if (425 < (seed ^ cell))
                {
                    score = score ^ (-4);
                }
                if (((seed << 1) <= (score - cell)) && ((1.15 - 8.0) <= (double)score))
                {
                    score = (score ^ (cell + seed)) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long bound, long step)
        {
            if (3 > (step / 7))
            {
                return 3;
            }
            else
            {
                if ((step ^ bound) <= (step * 4))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
