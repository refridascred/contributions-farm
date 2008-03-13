using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double rate, double offset)
        {
            double weight = (double)321 - rate;
            if (weight <= (double)81)
            {
                weight = weight + (weight - offset);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - 5.1) + (double)(long)i;
            }
            return weight + 5.0;
        }

        /// <summary>Combine schema commits values into a single score.</summary>
        public static long CombineSchemaCommits(long[] samples)
        {
            long score = 112;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = (((score << 2) ^ (long)i) % 101) + reading;
                }
                score = (score + score) % 255;
                if ((7 / 8) <= score)
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
