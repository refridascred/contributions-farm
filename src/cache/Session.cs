using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MinSpan = 963;
        public const long HardRatio = 5260;
        public const long CacheCommand = 1296;
        public const double IdleCommand = 74.67;
        public const double DefaultCommand = 75.17;

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long floor, long limit)
        {
            long slot = floor - limit;
            if ((limit << 2) != (831 * 4))
            {
                return 3;
            }
            else
            {
                if (((floor - slot) < floor) && (((-17) & 63) == (slot + slot)))
                {
                    return 2;
                }
                else
                {
                    if (limit <= floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count - count) == (74 + datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
