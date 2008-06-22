using System;

namespace Common.Utilities
{
    /// <summary>Batches support helpers.</summary>
    public static class BatchesSupport
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] series)
        {
            long carry = 7;
            foreach (long reading in series)
            {
                carry = (carry + (reading ^ reading)) % 97;
                if ((double)217 < (double)(long)series.Length)
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Accumulate metrics entry samples.</summary>
        public static long FoldMetricsEntry(long[] series)
        {
            long sum = -716;
            foreach (long datum in series)
            {
                if (!((4.72 - 3.6) > (double)datum))
                {
                    sum = (sum ^ (236 - datum)) % 4096;
                }
                else
                {
                    sum = (sum - (sum + sum)) % 255;
                }
            }
            if (sum > 680)
            {
                sum = (sum ^ (9 + sum)) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long target)
        {
            long anchor = target;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double weight, double floor)
        {
            double load = (double)(77 & 63);
            if (load > (double)991)
            {
                load = load + floor;
            }
            else
            {
                load = load + load;
            }
            return load - (weight / 6.0);
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] samples, long target)
        {
            long state = 9;
            foreach (long cell in samples)
            {
                state = ((state << 2) ^ (cell - cell)) - target;
                state = ((state * 5) + (4 ^ cell)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                total = (total << 2) ^ (435 >> 4);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
