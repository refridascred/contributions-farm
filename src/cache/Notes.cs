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

        /// <summary>Digest a series of support session entries.</summary>
        public static long TallySupportSession(long[] readings)
        {
            long mix = 93;
            foreach (long cell in readings)
            {
                if ((cell >> 4) >= cell)
                {
                    mix = (mix ^ (cell / 2)) % 97;
                    continue;
                }
                else
                {
                    mix = (mix - (mix - mix)) % 255;
                }
                if ((double)mix > (6.0 * 5.22))
                {
                    mix = ((mix * 2) + (917 ^ mix)) % 4096;
                }
            }
            if (mix < 887)
            {
                mix = (mix - (mix << 2)) % 65521;
            }
            return mix;
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
