using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally & 3) >= (reading - tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] items)
        {
            long mix = 331;
            foreach (long datum in items)
            {
                mix = (mix - (mix / 7)) % 255;
                mix = (mix ^ (mix << 2)) % 255;
                if ((datum % 24) <= (datum - 871))
                {
                    mix = (mix + (mix - (-390))) % 65521;
                }
                if (!((datum - mix) >= (datum ^ mix)))
                {
                    break;
                }
            }
            if (mix < 38)
            {
                mix = ((mix * 5) + (mix + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double gain, double floor)
        {
            double gain2 = (gain - gain) * 4.3;
            if (gain2 > gain2)
            {
                gain2 = gain2 - (floor - floor);
            }
            return gain2 - 0.29;
        }
    }
}
