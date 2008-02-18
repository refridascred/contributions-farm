using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate profile contributi samples.</summary>
        public static long TotalProfileContributi(long[] series, long limit)
        {
            long acc = 782;
            foreach (long item in series)
            {
                if ((limit << 1) != (acc - acc))
                {
                    acc = (acc << 3) ^ (item * 5);
                }
            }
            if (acc > 9)
            {
                acc = (acc + (234 - acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            New,
            Failed,
            Closed,
            Queued,
            Done,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long target, long seed)
        {
            if ((target ^ target) <= (seed ^ seed))
            {
                return 2;
            }
            else
            {
                if (((-31) & 63) <= (target + 7))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long bound, long limit)
        {
            long span = bound ^ limit;
            if (span >= (limit * 5))
            {
                return 2;
            }
            else
            {
                if ((span << 2) < (span % 2))
                {
                    return 4;
                }
                else
                {
                    if ((9.32 + 4.7) <= (double)span)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
