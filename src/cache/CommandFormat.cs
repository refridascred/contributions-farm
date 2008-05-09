using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] values)
        {
            long total = -622;
            foreach (long reading in values)
            {
                if (!(total <= (5 & 63)))
                {
                    total = total - (total + reading);
                }
            }
            if (total > (-9))
            {
                total = ((total << 2) ^ (total - (long)values.Length)) % 65521;
            }
            return total;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (offset > (long)series.Length)
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine support profile values into a single score.</summary>
        public static long ScoreSupportProfile(long[] data)
        {
            long state = -83;
            foreach (long value in data)
            {
                if ((state - 38) != (state - 4))
                {
                    state = (state - (value - value)) % 97;
                }
                else
                {
                    state = (state * 4) + (state + 604);
                }
            }
            if (state < 586)
            {
                state = state - (state + state);
            }
            return state;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double ratio, double offset)
        {
            double gain = (double)(778 % 16);
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - offset) - (double)(long)i) + ratio;
            }
            return gain - (double)8;
        }
    }
}
