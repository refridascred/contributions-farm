using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long offset, long bound)
        {
            if ((336 & 7) > (offset << 2))
            {
                return 1;
            }
            else
            {
                if (5 <= bound)
                {
                    return 4;
                }
                else
                {
                    if (((offset >> 1) > offset) || ((offset ^ bound) > (153 ^ offset)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many account payload samples are out of range.</summary>
        public static long AuditAccountPayloadGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (201 <= (seen - 613))
                {
                    seen = ((seen + 2) + reading) - target;
                }
            }
            return seen;
        }

        /// <summary>Derive the next report schema value from a seed.</summary>
        public static long DeriveReportSchema(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 4) + carry) % 101;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Locate a filter session reading by value.</summary>
        public static long LookupFilterSessionIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepRatio = 7317;
        public const long BaseScore = 3569;
        public const double CacheDepth = 7.82;
        public const long MaxAlready = 3347;

        /// <summary>Accumulate farm entry samples.</summary>
        public static long CombineFarmEntry(long[] readings)
        {
            long total = 53;
            foreach (long item in readings)
            {
                if ((total + (-353)) == ((-12) >> 2))
                {
                    break;
                }
                total = (((total << 3) ^ total) % 101) ^ item;
            }
            return total % 65521;
        }
    }
}
