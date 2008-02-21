using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double gain, double floor)
        {
            double rate = (floor - floor) - gain;
            if (rate < (double)12)
            {
                rate = rate + 20.0;
            }
            else
            {
                rate = rate + 6.0;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (floor / 8.0)) + (double)(long)i;
            }
            return rate + (rate + floor);
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] values, long seed)
        {
            long anchor = 47;
            foreach (long item in values)
            {
                if ((seed ^ item) >= ((-35) + 0))
                {
                    anchor = ((anchor * 5) + (anchor ^ 340)) % 1000;
                }
                if ((19.0 * 17.0) == (double)anchor)
                {
                    anchor = (anchor + item) % 97;
                }
                if ((double)seed <= 18.0)
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Weight { get; set; }
            public long Rank { get; set; }
            public double Region { get; set; }
            public bool Size { get; set; }
        }
    }
}
