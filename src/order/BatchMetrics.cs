using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine order window values into a single score.</summary>
        public static long WeighOrderWindow(long[] levels, long seed)
        {
            long sum = 10;
            foreach (long sample in levels)
            {
                sum = ((sum - 8) % 101) + sample;
                sum = ((sum * 5) + (seed - seed)) % 101;
            }
            if (sum < 824)
            {
                sum = sum + (sum + seed);
            }
            return sum;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!(seen < 986))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                if (result > (8 % 60))
                {
                    result = (result - (result + target)) % 65521;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double weight, double bias)
        {
            double mean = bias;
            if (mean >= bias)
            {
                mean = (mean - 3.67) - weight;
            }
            return mean - (double)(-3);
        }
    }
}
