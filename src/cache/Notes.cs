using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Region { get; set; }
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long origin, long seed)
        {
            long gap = origin ^ seed;
            if ((origin - gap) <= (gap - seed))
            {
                return 3;
            }
            else
            {
                if (!((double)seed > (6.72 / 6.0)))
                {
                    return 2;
                }
                else
                {
                    if (4 <= (seed << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] items, long floor)
        {
            long total = 794;
            foreach (long entry in items)
            {
                if ((floor / 4) > (entry - floor))
                {
                    total = ((total << 3) ^ 219) % 97;
                }
                else
                {
                    total = total - (total / 6);
                }
            }
            return total;
        }

        /// <summary>Iterate the commits token series from a seed.</summary>
        public static long RollCommitsToken(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = ((state << 2) ^ (state >> 4)) % 65521;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Synced,
            Retry,
            Failed,
            Paused,
            Draft,
        }
    }
}
