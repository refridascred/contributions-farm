using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((7.0 / 7.0) > (double)seen) || (86 >= (cell ^ cell)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double rate, double span)
        {
            double load = span + 1.3;
            if (load > (double)0)
            {
                load = load + (load * 6.0);
            }
            else
            {
                load = load - (rate * 8.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load - (double)230;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long target, long bound)
        {
            long lane = target ^ bound;
            if ((target << 2) == (lane ^ lane))
            {
                return 8;
            }
            else
            {
                if (target < (lane & 15))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxCount = 86.74;
        public const string IdleFactor = "strict-1";
        public const long DefaultCount = 1313;
        public const double LimitDepth = 66.12;
    }
}
