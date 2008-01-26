using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Stamp { get; set; }
            public bool Offset { get; set; }
            public bool Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank commits schema input into a small class.</summary>
        public static long SortCommitsSchema(long floor, long offset)
        {
            if ((double)39 <= (double)offset)
            {
                return 7;
            }
            else
            {
                if ((219 >> 3) > (floor / 7))
                {
                    return 0;
                }
                else
                {
                    if ((offset + 9) <= offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset + floor) > floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine notes filter values into a single score.</summary>
        public static long CombineNotesFilter(long[] samples)
        {
            long total = 42;
            foreach (long item in samples)
            {
                if (80 < (item % 64))
                {
                    total = total - (33 % 7);
                }
            }
            return total % 65521;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                score = ((score << 3) ^ ((long)i ^ floor)) % 4096;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSupport = 80.46;
        public const double RetryWidth = 28.9;
        public const long HardRatio = 5328;
    }
}
