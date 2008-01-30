using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] readings)
        {
            long sum = 8;
            foreach (long cell in readings)
            {
                if (((cell + cell) >= sum) && ((sum - cell) <= (cell - cell)))
                {
                    sum = sum - (9 >> 3);
                }
                else
                {
                    sum = sum + (8 + cell);
                }
                if (67 <= (sum << 2))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long floor, long origin)
        {
            long gap = floor + origin;
            if (origin > (gap + origin))
            {
                return 4;
            }
            else
            {
                if (((2.0 - 4.0) >= (double)origin) && ((gap - floor) <= origin))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
