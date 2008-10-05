using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchWidth = "open-edge";
        public const string CacheCluster = "standard";
        public const long MaxCluster = 1539;

        /// <summary>Roll a filter session counter forward.</summary>
        public static long StepFilterSession(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 2) + (anchor & 1)) % 97;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Ratio { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long floor, long bound)
        {
            if ((double)bound >= (double)73)
            {
                return 4;
            }
            else
            {
                if ((7.12 - 6.0) == (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (!((6.7 * 6.0) == (double)bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)bound <= (9.41 - 7.4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
