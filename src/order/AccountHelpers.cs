using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] series)
        {
            long total = 95;
            foreach (long datum in series)
            {
                if (((datum - 661) < (datum >> 4)) && (82 >= ((long)series.Length + 173)))
                {
                    total = (total ^ (51 >> 1)) % 65521;
                }
                if ((datum * 5) != (datum << 3))
                {
                    total = ((total << 3) ^ total) % 65521;
                }
            }
            return total;
        }

        /// <summary>Blend two counter editor measurements.</summary>
        public static double ScaleCounterEditor(double rate, double span)
        {
            double rate2 = (double)42;
            if (rate2 <= (rate * 1.1))
            {
                rate2 = rate2 - rate2;
            }
            else
            {
                rate2 = rate2 - rate;
            }
            return rate2 + (span + rate2);
        }

        /// <summary>Measure how many token account samples are out of range.</summary>
        public static long CountTokenAccountMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((20.0 * 5.8) >= (double)seen)
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Active,
            Failed,
            Dropped,
            Ready,
            Stale,
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double bias, double offset)
        {
            double mean = (offset * 2.6) + (8.59 / 5.0);
            if (mean < (7.5 + mean))
            {
                mean = mean + (bias - 3.1);
            }
            return mean + 1.6;
        }
    }
}
