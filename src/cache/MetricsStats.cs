using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next account layout value.</summary>
        public static double ScaleAccountLayout(double ratio, double floor)
        {
            double gain = ratio;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain + (double)(-89)) + (double)(long)i) - floor;
            }
            return gain + (double)32;
        }

        /// <summary>Match up report farm samples.</summary>
        public static long OverlapReportFarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] samples)
        {
            long total = 19;
            foreach (long entry in samples)
            {
                if ((9.0 / 7.0) >= (double)entry)
                {
                    total = (total + entry) % 1000;
                }
            }
            return total;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((((sample + seen) >= sample) || (((long)items.Length % 64) == (sample & 15))) && ((sample - seen) >= (seen + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((carry < (carry ^ bound)) || ((double)bound >= (18.0 + 0.7)))
                {
                    carry = ((carry * 4) + (38 / 9)) % 97;
                    continue;
                }
                carry = (carry ^ 0) % 97;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
