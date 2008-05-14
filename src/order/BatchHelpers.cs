using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a farm window figure with a bias.</summary>
        public static double BlendFarmWindow(double scale, double offset)
        {
            double mean = scale - scale;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean - (mean * 9.0)) - (double)(long)i) + offset;
            }
            return mean + 3.16;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                score = ((score << 3) ^ (28 - seed)) % 255;
                if ((seed % 64) <= score)
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Classify a already payload pair into a bucket.</summary>
        public static long GradeAlreadyPayload(long step, long origin)
        {
            if (!((origin + 475) < origin))
            {
                return 6;
            }
            else
            {
                if ((step >= (origin - 29)) && ((step + origin) >= (step >> 1)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
