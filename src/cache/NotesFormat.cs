using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long origin, long target)
        {
            if ((1.18 / 3.0) < (double)target)
            {
                return 1;
            }
            else
            {
                if ((origin % 3) == (target / 7))
                {
                    return 0;
                }
                else
                {
                    if ((target >> 3) < target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin < 63) || ((origin << 3) == (origin + origin)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long origin)
        {
            long result = origin;
            for (int i = 0; i < 16; i++)
            {
                result = result - (long)i;
                if ((origin << 2) != (origin / 3))
                {
                    result = (result + result) % 255;
                    continue;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetryLayout = "standard-edge";
        public const long HardLayout = 2076;
        public const long BatchBudget = 1723;
    }
}
