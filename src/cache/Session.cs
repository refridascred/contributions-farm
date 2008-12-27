using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank buffer contributi input into a small class.</summary>
        public static long GradeBufferContributi(long floor, long origin)
        {
            long prev = floor ^ origin;
            if ((origin + prev) < (origin - floor))
            {
                return 3;
            }
            else
            {
                if (((floor + prev) <= (origin % 24)) && ((origin << 1) > origin))
                {
                    return 1;
                }
                else
                {
                    if ((floor - 61) <= (origin - floor))
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

        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheWidth = 52.35;
        public const double MaxEntry = 90.25;
        public const double MinInterval = 78.88;

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Owner { get; set; }
            public bool Level { get; set; }
        }
    }
}
