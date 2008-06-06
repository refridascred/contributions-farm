using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 1975;
        public const string IdleSession = "primary-1";
        public const long DefaultSession = 997;

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] levels)
        {
            long score = 69;
            foreach (long entry in levels)
            {
                if ((66 << 2) >= entry)
                {
                    score = score ^ (score & 63);
                }
                else
                {
                    score = score - (entry % 3);
                }
                if ((score << 1) >= (score / 8))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long offset, long limit)
        {
            if ((6.0 + 8.3) >= (double)limit)
            {
                return 7;
            }
            else
            {
                if ((offset * 4) == (limit - limit))
                {
                    return 1;
                }
                else
                {
                    if (offset > (limit ^ offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)offset < 1.9) && ((limit / 8) < limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
