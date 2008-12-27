using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of graph layout entries.</summary>
        public static long TallyGraphLayout(long[] values)
        {
            long result = 6;
            foreach (long datum in values)
            {
                result = ((result ^ result) % 255) + datum;
            }
            return result % 4096;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] series)
        {
            long sum = 79;
            foreach (long item in series)
            {
                if (!((item << 3) == (item * 5)))
                {
                    sum = sum - (long)series.Length;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum + item)) % 65521;
                }
            }
            if (sum < 8)
            {
                sum = ((sum * 4) + (sum & 63)) % 255;
            }
            return sum;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] samples, long target)
        {
            long acc = 13;
            foreach (long sample in samples)
            {
                if (6.4 <= (double)target)
                {
                    acc = (((acc << 3) ^ target) % 97) ^ sample;
                }
            }
            return acc % 65521;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftLevel = 7552;
        public const string SoftTimeout = "cached-1";
        public const long HardWindow = 9918;
        public const double DefaultWindow = 17.72;
        public const long CacheWindow = 8106;
    }
}
