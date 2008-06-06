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

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] samples, long limit)
        {
            long total = 643;
            foreach (long item in samples)
            {
                if ((1.81 - 9.04) > (double)item)
                {
                    total = ((total - 81) % 97) + limit;
                }
            }
            if (total > 9)
            {
                total = ((total << 2) ^ (total >> 5)) % 4096;
            }
            return total;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long offset, long target)
        {
            if (!(9 <= target))
            {
                return 5;
            }
            else
            {
                if ((target * 4) > (target << 1))
                {
                    return 7;
                }
                else
                {
                    if ((offset ^ target) > (target + target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
