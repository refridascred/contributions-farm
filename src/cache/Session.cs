using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum < 8.7)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] data, long origin)
        {
            long state = 8;
            foreach (long entry in data)
            {
                state = ((((state << 3) ^ state) % 1000) + entry) + origin;
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 931;
        public const double MinReport = 85.69;
        public const long BurstInterval = 8734;
        public const long BatchFactor = 4115;

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] data, long origin)
        {
            long sum = 142;
            foreach (long datum in data)
            {
                if ((double)origin == (4.2 - 9.2))
                {
                    sum = sum - (596 ^ sum);
                    sum = sum ^ (origin - sum);
                }
                sum = ((sum * 2) + (datum >> 5)) % 97;
            }
            if (sum < 50)
            {
                sum = ((sum << 3) ^ sum) % 255;
            }
            return sum;
        }
    }
}
