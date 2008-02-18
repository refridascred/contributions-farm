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

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
