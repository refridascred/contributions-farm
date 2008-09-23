using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double gain, double span)
        {
            double drift = (gain * 8.3) - span;
            if (drift > 2.5)
            {
                drift = drift - (drift + span);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - (drift / 3.0);
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally + tally) > tally)
                {
                    tally = (tally + 2) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    long matches = (seed + seed) >> 3;
                    anchor = (((anchor * 5) + matches) % 4096) + (long)i2;
                }
                if (((seed - 814) != (836 << 1)) || ((16.0 - 19.0) != (double)seed))
                {
                    anchor = anchor + (anchor + seed);
                    break;
                }
                else
                {
                    anchor = (anchor * 3) + anchor;
                }
                for (int i3 = 0; i3 < 10; i3++)
                {
                    anchor = ((anchor * 3) + (long)i3) % 255;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
