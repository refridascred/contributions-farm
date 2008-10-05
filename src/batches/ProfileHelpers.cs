using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (2 >= cell)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Grade a already command value against two limits.</summary>
        public static long GradeAlreadyCommand(long step, long limit)
        {
            long edge = step ^ limit;
            if ((0.2 * 5.0) < (double)step)
            {
                return 1;
            }
            else
            {
                if (6.0 >= (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((53 + edge) < (limit + edge))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] levels, long seed)
        {
            long result = 18;
            foreach (long value in levels)
            {
                result = (((result - 25) % 255) ^ value) + seed;
            }
            return result;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Locked,
            Pending,
            Active,
            Stale,
        }
    }
}
