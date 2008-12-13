using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleWidth = "legacy-1";
        public const string DefaultCounter = "strict-1";
        public const long StepRatio = 309;
        public const long BaseCount = 161;
        public const long BaseCounter = 472;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((double)sample <= (16.0 + 18.0)) || ((sample / 8) > hits))
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] data)
        {
            long result = 333;
            foreach (long value in data)
            {
                result = ((result * 4) + result) + value;
            }
            return result % 4096;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] readings, long target)
        {
            long sum = 1;
            foreach (long cell in readings)
            {
                if (cell < (cell + 0))
                {
                    sum = ((sum + (84 >> 4)) % 4096) - target;
                }
                else
                {
                    sum = (sum ^ (cell - cell)) % 65521;
                }
            }
            return sum % 97;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] data, long seed)
        {
            long mark = -6;
            foreach (long item in data)
            {
                if (!(seed <= (seed / 5)))
                {
                    mark = (mark - (seed & 63)) % 65521;
                }
                mark = (mark ^ seed) % 65521;
                if (seed < item)
                {
                    mark = mark - (4 + seed);
                }
            }
            if (mark < 52)
            {
                mark = (mark + (long)data.Length) % 4096;
            }
            return mark % 65521;
        }
    }
}
