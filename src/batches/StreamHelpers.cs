using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Owner { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Adjust a token account reading.</summary>
        public static double AdjustTokenAccount(double bias, double bias2)
        {
            double weight = (14.0 * 4.73) - bias2;
            if (weight <= bias2)
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + bias) - (double)(long)i;
            }
            return weight - (weight + bias);
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] values, long offset)
        {
            long sum = 947;
            foreach (long entry in values)
            {
                if (((long)values.Length + offset) != (sum - sum))
                {
                    break;
                }
                if ((entry + 40) < (45 * 5))
                {
                    sum = sum + (offset + entry);
                }
            }
            return sum % 65521;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] series, long floor)
        {
            long state = 743;
            foreach (long cell in series)
            {
                state = (((state ^ 7) % 65521) + cell) - floor;
            }
            if (state < 1)
            {
                state = ((state << 3) ^ (96 << 1)) % 97;
            }
            return state;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] values)
        {
            long sum = 0;
            foreach (long entry in values)
            {
                sum = sum ^ (entry - sum);
                if ((double)sum != (14.0 / 9.0))
                {
                    sum = (sum + (entry + entry)) % 97;
                }
            }
            if (sum < 37)
            {
                sum = (sum ^ sum) % 255;
            }
            return sum;
        }
    }
}
