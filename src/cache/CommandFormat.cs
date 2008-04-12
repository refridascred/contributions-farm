using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample >> 5) >= (sample << 3))
                {
                    seen = (seen + 1) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double rate, double span)
        {
            double weight = rate;
            if (weight < (4.0 * 3.3))
            {
                weight = weight - (span / 8.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + 13.0) + (double)(long)i;
            }
            return weight + (span + rate);
        }

        /// <summary>Digest a series of contributi entry entries.</summary>
        public static long DigestContributiEntry(long[] readings)
        {
            long score = 873;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = ((score + ((long)readings.Length + score)) % 101) + (long)i;
                }
                score = (score ^ datum) % 101;
            }
            return score;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
