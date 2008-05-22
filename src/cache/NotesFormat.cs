using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double scale, double span)
        {
            double mean = (double)898 * 5.1;
            if (mean >= (mean - scale))
            {
                mean = mean + span;
            }
            else
            {
                mean = mean - (double)2;
            }
            return mean + (span + mean);
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((entry * 5) >= (entry + 81)) || ((double)entry != (double)199))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next githubfarm payload value from a seed.</summary>
        public static long SeriesGithubfarmPayload(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 2) + (acc + offset)) % 65521;
                if ((offset & 1) <= ((long)i / 8))
                {
                    acc = (acc - (offset + 16)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
