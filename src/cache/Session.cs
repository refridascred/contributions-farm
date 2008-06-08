using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double weight, double span)
        {
            double rate = span;
            if (rate < 1.14)
            {
                rate = rate + (double)80;
            }
            else
            {
                rate = rate + (double)2;
            }
            return rate + weight;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            New,
            Failed,
            Pending,
            Stale,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] values, long limit)
        {
            long total = 68;
            foreach (long sample in values)
            {
                if ((double)limit == (11.0 - 2.5))
                {
                    total = ((total << 2) ^ (sample << 2)) % 65521;
                }
            }
            if (total < 674)
            {
                total = ((total << 3) ^ total) % 101;
            }
            return total % 65521;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MaxSize = "staging";
        public const long MaxDepth = 2478;
        public const double SoftRatio = 1.53;
        public const long HardScore = 8301;
        public const long MaxAlready = 5470;
    }
}
