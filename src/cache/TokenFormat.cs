using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Draft,
            Active,
            New,
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double gain, double floor)
        {
            double rate = (floor - floor) / 3.0;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + gain) + (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long limit)
        {
            long score = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((double)limit > (18.0 - 12.0))
                {
                    score = ((score << 3) ^ (long)i) % 4096;
                    break;
                }
                if (!(limit >= (score & 255)))
                {
                    score = score ^ (score % 60);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
