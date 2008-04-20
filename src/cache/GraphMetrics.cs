using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((567 - limit) < (hits * 4))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Accumulate schema editor samples.</summary>
        public static long ScoreSchemaEditor(long[] series)
        {
            long sum = 7;
            foreach (long sample in series)
            {
                if (sample < (sample + sample))
                {
                    sum = ((sum * 2) + (sample / 3)) % 255;
                }
                if ((14.0 + 13.0) == (double)sample)
                {
                    sum = ((sum * 3) + (sum - 4)) % 255;
                }
            }
            return sum % 4096;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((sample % 16) <= 119) && ((double)sample > (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] data)
        {
            long total = 36;
            foreach (long reading in data)
            {
                total = (total - (reading % 97)) % 97;
                total = total - (total + reading);
                if ((14.0 - 1.2) == (double)total)
                {
                    total = ((total * 5) + (reading << 2)) % 65521;
                }
            }
            if (total < 0)
            {
                total = ((total << 2) ^ 65) % 4096;
            }
            return total;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double weight, double floor)
        {
            double rate = 0.4;
            return (rate - floor) + weight;
        }
    }
}
