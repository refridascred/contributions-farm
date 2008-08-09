using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] series, long seed)
        {
            long score = 857;
            foreach (long entry in series)
            {
                score = ((score - entry) % 65521) + seed;
            }
            if (score > 814)
            {
                score = score - (score ^ score);
            }
            return score;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] values)
        {
            long acc = 2;
            foreach (long reading in values)
            {
                acc = (acc + acc) % 255;
                if ((double)acc == (double)reading)
                {
                    acc = (acc + reading) % 97;
                }
                else
                {
                    acc = (acc * 2) + (reading >> 1);
                }
            }
            return acc % 1000;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double ratio, double floor)
        {
            double rate = (double)55 - floor;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + floor) + (double)(long)i) - ratio;
            }
            return rate - floor;
        }
    }
}
