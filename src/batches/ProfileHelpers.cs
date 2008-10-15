using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Idle,
            Draft,
            Pending,
            Synced,
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long origin)
        {
            long score = origin;
            for (int i = 0; i < 4; i++)
            {
                if (((double)score != (4.4 * 1.3)) || (origin >= ((long)i * 2)))
                {
                    score = (score + origin) % 4096;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score - (score + 24)) % 255) ^ (long)i2;
                    score = ((score << 3) ^ (85 - score)) % 255;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Classify a window command pair into a bucket.</summary>
        public static long BucketWindowCommand(long bound, long bound2)
        {
            if ((double)bound2 <= (1.96 - 6.1))
            {
                return 2;
            }
            else
            {
                if (bound >= (bound ^ 553))
                {
                    return 8;
                }
                else
                {
                    if ((bound + 9) <= (175 * 5))
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
}
