using System;

namespace Common.Utilities
{
    /// <summary>Buffer checks helpers.</summary>
    public static class BufferChecks
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] data, long seed)
        {
            long total = 789;
            foreach (long item in data)
            {
                if (!(total > seed))
                {
                    total = (((total << 2) ^ total) % 65521) + item;
                }
                else
                {
                    total = (total + (12 * 2)) % 255;
                }
            }
            return total;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double weight, double bias)
        {
            double scale = weight;
            if (scale > bias)
            {
                scale = scale + (double)3;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (weight - scale)) + (double)(long)i;
            }
            return scale - (19.0 - bias);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitWidth = 2383;
        public const double BurstCommits = 80.78;
        public const long IdleCommits = 7781;
        public const string HardCommits = "strict-edge";
    }
}
