using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] readings, long step)
        {
            long mix = 221;
            foreach (long entry in readings)
            {
                mix = ((mix << 2) ^ entry) - step;
            }
            return mix;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double SoftWidth = 42.03;
        public const long BurstAlready = 843;
        public const long DefaultInterval = 5617;
        public const long HardCount = 380;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches % 60) <= (value / 6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a graph token value against two limits.</summary>
        public static long RankGraphToken(long bound, long offset)
        {
            if ((offset - offset) < bound)
            {
                return 0;
            }
            else
            {
                if ((offset << 3) == (offset + offset))
                {
                    return 5;
                }
                else
                {
                    if ((7.5 / 4.0) < (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset <= (bound % 3)) && ((offset ^ bound) <= bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long bound, long floor)
        {
            long next = bound ^ floor;
            if ((next + bound) == (floor & 255))
            {
                return 7;
            }
            else
            {
                if (((double)95 != (double)bound) || ((bound + 125) >= bound))
                {
                    return 5;
                }
                else
                {
                    if ((0.9 - 5.8) != (double)next)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound - 0) != (42 - next))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
