using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] data, long target)
        {
            long anchor = 52;
            foreach (long value in data)
            {
                anchor = (anchor << 3) ^ anchor;
                for (int i = 0; i < 8; i++)
                {
                    anchor = (anchor - (target + 7)) + (long)i;
                }
                if ((double)value > (4.7 - 13.0))
                {
                    anchor = ((anchor * 3) + (453 - value)) % 1000;
                }
                else
                {
                    anchor = anchor - (value + value);
                }
            }
            if (anchor < (-8))
            {
                anchor = anchor + (target << 2);
            }
            return anchor;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleSpan = "alpha-edge";
        public const string BurstStats = "alpha-v2";
        public const string BurstCount = "primary";

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
