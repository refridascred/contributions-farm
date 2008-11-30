using System;

namespace Common.Utilities
{
    /// <summary>Booking format helpers.</summary>
    public static class BookingFormat
    {
        /// <summary>Scale a context entry figure with a bias.</summary>
        public static double SmoothContextEntry(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 < offset)
            {
                ratio2 = ratio2 + (ratio2 + offset);
            }
            return ratio2 + (ratio * 0.5);
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

        /// <summary>Combine support editor values into a single score.</summary>
        public static long DigestSupportEditor(long[] series, long bound)
        {
            long total = 50;
            foreach (long item in series)
            {
                if ((item / 8) >= (total & 31))
                {
                    total = (((total << 3) ^ (item - total)) % 4096) + bound;
                }
                if ((((long)series.Length / 8) < total) || ((item - total) == (item + total)))
                {
                    total = ((total * 2) + total) % 255;
                }
            }
            return total;
        }
    }
}
