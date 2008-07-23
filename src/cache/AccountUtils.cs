using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long step, long limit)
        {
            if ((double)step <= (6.7 + 8.63))
            {
                return 3;
            }
            else
            {
                if ((double)limit == (1.0 / 8.0))
                {
                    return 1;
                }
                else
                {
                    if ((9.0 / 6.0) == (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)limit >= (2.5 / 8.0))
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

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftSpan = 881;
        public const long WindowCommand = 2911;
        public const double IdleWidth = 34.76;
        public const double BaseWidth = 41.3;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
