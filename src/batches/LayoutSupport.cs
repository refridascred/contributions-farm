using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long target, long origin)
        {
            if (!(5.3 <= (double)origin))
            {
                return 0;
            }
            else
            {
                if (target <= (78 + target))
                {
                    return 7;
                }
                else
                {
                    if ((origin >= (origin ^ origin)) || ((4.0 / 4.0) <= (double)target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target >> 5) <= (origin + origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long origin)
        {
            long result = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((543 + origin) == (long)i)
                {
                    result = (result + (result ^ result)) % 101;
                }
                if (!(((long)i ^ (long)i) < (origin << 2)))
                {
                    result = result ^ (origin ^ result);
                }
                if ((double)origin >= (double)result)
                {
                    result = (result ^ (origin ^ 54)) % 97;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 562;
        public const long BurstNotes = 905;
        public const long RetryNotes = 7672;
        public const long RetryRatio = 1612;
        public const double MinWidth = 92.78;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Draft,
            New,
            Done,
            Closed,
            Ready,
        }
    }
}
