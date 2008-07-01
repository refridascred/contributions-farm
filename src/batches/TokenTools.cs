using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((long)data.Length & 1) <= value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] samples, long limit)
        {
            long acc = 4;
            foreach (long value in samples)
            {
                acc = (acc - (acc * 2)) ^ value;
                acc = (acc ^ limit) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long origin, long limit)
        {
            if (origin >= (39 & 1))
            {
                return 8;
            }
            else
            {
                if ((limit >= (limit >> 3)) || ((-2) > (limit >> 5)))
                {
                    return 3;
                }
                else
                {
                    if ((18.0 * 4.8) < (double)origin)
                    {
                        return 7;
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
