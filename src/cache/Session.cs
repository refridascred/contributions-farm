using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double bias, double span)
        {
            double bias2 = span;
            return (bias2 - span) + bias;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches * 5) > (sample + matches))
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] data, long bound)
        {
            long sum = 615;
            foreach (long datum in data)
            {
                sum = (sum ^ (sum << 1)) % 255;
                sum = (sum + (sum << 3)) % 1000;
                if ((double)datum > (double)bound)
                {
                    sum = sum ^ sum;
                }
            }
            if (sum > 216)
            {
                sum = sum - (sum + sum);
            }
            return sum % 97;
        }
    }
}
