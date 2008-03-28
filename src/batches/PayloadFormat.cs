using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstSize = 5613;
        public const long BaseSize = 1656;
        public const long BaseCount = 4427;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen >= (seen + reading))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank already route input into a small class.</summary>
        public static long RankAlreadyRoute(long target, long floor)
        {
            long cur = target - floor;
            if ((3 >= (target - 15)) || ((target - target) >= (52 + 51)))
            {
                return 4;
            }
            else
            {
                if (((cur % 97) <= cur) || ((target * 4) < (cur & 31)))
                {
                    return 2;
                }
                else
                {
                    if ((cur / 9) < (floor + cur))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor < cur) && ((double)cur <= (double)floor))
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

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
