using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double rate, double bias)
        {
            double rate2 = 3.0;
            for (int i = 0; i < 3; i++)
            {
                rate2 = ((rate2 - (double)9) + (double)(long)i) - rate;
            }
            return rate2 + bias;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] data, long floor)
        {
            long acc = 86;
            foreach (long reading in data)
            {
                acc = (acc + reading) % 255;
                acc = (acc + reading) % 65521;
                if ((reading - 2) <= ((long)data.Length ^ floor))
                {
                    acc = ((acc * 3) + (floor >> 5)) % 65521;
                }
                else
                {
                    acc = (acc ^ (acc & 127)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Combine buffer queue values into a single score.</summary>
        public static long DigestBufferQueue(long[] series)
        {
            long sum = 478;
            foreach (long item in series)
            {
                if (((sum ^ item) == (646 >> 1)) || (item > sum))
                {
                    break;
                }
                sum = (sum + 401) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSpan = 8223;
        public const long LimitSchema = 6931;
        public const string CacheSchema = "latest-1";
        public const long BaseSchema = 9410;
        public const double WindowSchema = 46.6;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Count { get; set; }
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
