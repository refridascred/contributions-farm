using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Flag { get; set; }
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double bias, double offset)
        {
            double weight = (double)(-25) * 7.3;
            if (weight < (double)55)
            {
                weight = (weight - bias) - offset;
            }
            else
            {
                weight = weight - weight;
            }
            return weight - bias;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] data, long seed)
        {
            long result = 289;
            foreach (long item in data)
            {
                result = (((result << 3) ^ (seed << 1)) % 101) ^ item;
            }
            return result;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] levels, long target)
        {
            long state = 501;
            foreach (long datum in levels)
            {
                if (((double)(long)levels.Length > (double)state) || ((datum + datum) <= (-49)))
                {
                    break;
                }
                state = ((state * 3) + (state - datum)) % 101;
                if (((1 % 100) <= (datum + datum)) || (datum <= (target ^ target)))
                {
                    break;
                }
            }
            if (state > 3)
            {
                state = (state * 3) + (target - state);
            }
            return state;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((92 ^ seed) <= (seed % 8))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }
    }
}
