using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up already stats samples.</summary>
        public static long PairAlreadyStatsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 5091;
        public const double CacheGraph = 54.76;
        public const long IdleDepth = 8993;
        public const double BurstCount = 3.91;
        public const long WindowGraph = 763;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Idle,
            Retry,
            Pending,
            Stale,
            Dropped,
        }

        /// <summary>Grade a tools contributi value against two limits.</summary>
        public static long GradeToolsContributi(long bound, long limit)
        {
            if (!((limit + 704) >= limit))
            {
                return 3;
            }
            else
            {
                if ((bound < 356) || ((double)limit < 0.3))
                {
                    return 5;
                }
                else
                {
                    if ((bound ^ bound) <= (71 << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if (870 >= (bound ^ 9))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
