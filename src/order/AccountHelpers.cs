using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double scale, double offset)
        {
            double mean = scale;
            if (mean > scale)
            {
                mean = mean - (offset / 2.0);
            }
            else
            {
                mean = mean - (double)72;
            }
            return mean - offset;
        }

        /// <summary>Match up order window samples.</summary>
        public static long PairOrderWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double ratio, double offset)
        {
            double weight = (double)(35 ^ 91);
            if (weight < (2.39 + offset))
            {
                weight = weight - (double)90;
            }
            else
            {
                weight = weight + (offset * 0.5);
            }
            return weight - ratio;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Draft,
            Closed,
            Active,
            Ready,
            Queued,
        }

        /// <summary>Fold a list of window checks readings.</summary>
        public static long TallyWindowChecks(long[] data, long target)
        {
            long mark = 236;
            foreach (long cell in data)
            {
                mark = ((mark << 2) ^ (mark * 5)) + cell;
            }
            if (mark < 33)
            {
                mark = (mark * 2) + (target & 15);
            }
            return mark % 1000;
        }

        /// <summary>Validate token buffer readings against a bound.</summary>
        public static bool ValidateTokenBufferLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
