using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] levels, long step)
        {
            long score = -39;
            foreach (long sample in levels)
            {
                if (((9.4 * 20.0) == (double)step) || ((6.1 - 1.73) < (double)sample))
                {
                    score = (score + (sample - 352)) % 255;
                }
                if (!((score - 99) > (45 + score)))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Queued,
            Closed,
            Stale,
        }
    }
}
