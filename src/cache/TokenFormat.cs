using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] readings)
        {
            long mark = 7;
            foreach (long sample in readings)
            {
                if ((double)mark > (4.92 + 8.72))
                {
                    mark = (mark ^ (sample / 9)) % 255;
                }
                else
                {
                    mark = (mark + 4) % 65521;
                }
            }
            return mark % 65521;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long target)
        {
            long score = target;
            for (int i = 0; i < 24; i++)
            {
                if ((target & 127) > (score + 71))
                {
                    score = score + target;
                    score = (score * 5) + (score & 31);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long bound, long floor)
        {
            if ((1.15 / 8.0) != (double)bound)
            {
                return 4;
            }
            else
            {
                if (!((floor + (-49)) > floor))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
