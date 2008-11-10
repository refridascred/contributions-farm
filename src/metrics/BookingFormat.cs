using System;

namespace Common.Utilities
{
    /// <summary>Booking format helpers.</summary>
    public static class BookingFormat
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (((state * 3) + (origin >> 3)) % 1000) - (long)i2;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 >= bias)
            {
                gain2 = gain2 - bias;
            }
            return gain2 + (gain / 6.0);
        }

        /// <summary>Audit batches report readings against a rule.</summary>
        public static long CountBatchesReportOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((7.39 + 10.0) >= (double)count) || ((8.0 * 7.1) >= (double)reading))
                {
                    count = (count + 2) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] series)
        {
            long acc = 6;
            foreach (long entry in series)
            {
                if (((acc ^ acc) != (acc & 15)) || (9 <= entry))
                {
                    acc = (acc + (entry - entry)) % 97;
                }
            }
            return acc % 97;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = score + 62;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
