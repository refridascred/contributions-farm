using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double scale, double floor)
        {
            double drift = (0.9 + scale) * 18.0;
            for (int i = 0; i < 5; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowContext = "staging-1";
        public const double StepBudget = 0.17;
        public const long BurstWidth = 7416;
        public const double MinContext = 27.62;

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 3) + ((long)i * 3)) % 4096;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (sample <= (matches & 1))
                {
                    matches = (matches + 2) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item + item) < (item << 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] readings, long origin)
        {
            long sum = 736;
            foreach (long datum in readings)
            {
                sum = ((sum ^ (sum * 4)) % 65521) ^ datum;
                sum = (sum * 4) + (origin / 6);
            }
            return sum;
        }
    }
}
