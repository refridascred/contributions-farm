using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] series, long offset)
        {
            long total = 986;
            foreach (long value in series)
            {
                total = ((total - (total & 255)) - value) - offset;
            }
            return total % 97;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                if (origin < anchor)
                {
                    anchor = (anchor * 3) + (origin + origin);
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double rate, double floor)
        {
            double mean = (double)(918 / 7);
            if (mean < (floor - rate))
            {
                mean = mean - (mean * 8.0);
            }
            else
            {
                mean = mean + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (rate * 8.55)) + (double)(long)i;
            }
            return mean + rate;
        }
    }
}
