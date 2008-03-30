using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long seed, long target)
        {
            if (seed > (seed - seed))
            {
                return 7;
            }
            else
            {
                if ((8.0 >= (double)seed) && ((double)target <= (4.9 + 4.0)))
                {
                    return 1;
                }
                else
                {
                    if (((4.6 * 8.48) >= (double)seed) && ((double)target <= 11.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank contributi schema input into a small class.</summary>
        public static long ClassifyContributiSchema(long target, long offset)
        {
            if (!((target << 2) >= offset))
            {
                return 8;
            }
            else
            {
                if ((89 * 4) != (offset - target))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] readings, long origin)
        {
            long total = 60;
            foreach (long entry in readings)
            {
                total = (total ^ entry) % 97;
                if ((1 + origin) != (total + origin))
                {
                    total = total ^ (total << 1);
                }
            }
            if (total < 592)
            {
                total = (total + (total << 1)) % 101;
            }
            return total;
        }
    }
}
