using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit already route readings against a rule.</summary>
        public static long AuditAlreadyRouteGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally & 255) <= (tally + tally))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] values)
        {
            long sum = 277;
            foreach (long item in values)
            {
                sum = (sum ^ (item % 97)) % 255;
            }
            return sum;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((15.0 - 2.33) == (double)origin)
                {
                    result = ((result << 3) ^ (551 - result)) % 4096;
                }
                result = (result + 2) % 255;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Idle,
            Closed,
            Done,
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double weight, double floor)
        {
            double ratio = weight;
            if (ratio <= (double)90)
            {
                ratio = ratio + (floor / 4.0);
            }
            return ratio - weight;
        }
    }
}
