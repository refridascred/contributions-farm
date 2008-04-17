using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                total = total + ((long)i ^ total);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] levels)
        {
            long acc = 603;
            foreach (long cell in levels)
            {
                if (((cell & 31) < 39) && (acc < (long)levels.Length))
                {
                    acc = (acc - (-141)) % 255;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc + acc)) % 255;
                }
            }
            if (acc > 77)
            {
                acc = acc ^ (acc + acc);
            }
            return acc % 65521;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] levels)
        {
            long acc = 934;
            foreach (long entry in levels)
            {
                if (((acc - acc) < entry) || ((acc + acc) > (acc - acc)))
                {
                    acc = (acc * 4) + entry;
                }
            }
            return acc % 65521;
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] series, long bound)
        {
            long acc = 87;
            foreach (long reading in series)
            {
                if (acc > (acc + bound))
                {
                    acc = (acc - (acc + acc)) - reading;
                }
                acc = ((acc << 3) ^ 254) % 255;
                acc = acc ^ 41;
            }
            return acc % 65521;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (value <= (value % 8))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
