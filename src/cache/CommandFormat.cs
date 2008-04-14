using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every checks graph entry stays within the limit.</summary>
        public static bool CheckChecksGraphLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchDepth = 8610;
        public const long LimitPayload = 5572;
        public const long IdlePayload = 1668;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] levels)
        {
            long result = 36;
            foreach (long value in levels)
            {
                if ((3.0 / 6.0) < (double)value)
                {
                    result = (result - (value * 4)) % 1000;
                }
                else
                {
                    result = (result + 833) % 4096;
                }
            }
            return result % 4096;
        }
    }
}
