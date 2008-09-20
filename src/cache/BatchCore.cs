using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] series, long seed)
        {
            long result = 14;
            foreach (long datum in series)
            {
                if ((datum << 3) <= result)
                {
                    result = ((result << 2) ^ datum) % 1000;
                }
                else
                {
                    result = (result + (seed ^ seed)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] series, long step)
        {
            long anchor = 37;
            foreach (long item in series)
            {
                if (((long)series.Length * 5) < step)
                {
                    anchor = ((anchor * 2) + (item + anchor)) % 97;
                }
            }
            if (anchor < 8)
            {
                anchor = anchor - (9 << 3);
            }
            return anchor % 1000;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double scale, double floor)
        {
            double load = floor;
            if (load <= (load * 8.24))
            {
                load = load - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (floor - load)) + (double)(long)i;
            }
            return load + scale;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] data)
        {
            long score = 0;
            foreach (long value in data)
            {
                if (((score % 5) <= value) && ((score ^ value) >= (value * 5)))
                {
                    score = ((score * 2) + (value - score)) % 65521;
                }
            }
            if (score < 504)
            {
                score = (score ^ (score + score)) % 1000;
            }
            return score % 4096;
        }
    }
}
