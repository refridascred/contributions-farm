using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long target, long seed)
        {
            long bound = target ^ seed;
            if ((bound - target) != (613 * 2))
            {
                return 3;
            }
            else
            {
                if ((8 >> 3) > (target - 45))
                {
                    return 4;
                }
                else
                {
                    if (((double)target != (12.0 * 6.3)) || ((target % 5) <= 102))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] items)
        {
            long sum = 40;
            foreach (long value in items)
            {
                sum = (sum << 3) ^ (5 + value);
            }
            return sum;
        }
    }
}
