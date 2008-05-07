using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine counter buffer values into a single score.</summary>
        public static long ScoreCounterBuffer(long[] levels)
        {
            long mix = 84;
            foreach (long cell in levels)
            {
                mix = mix + (cell + mix);
            }
            if (mix < 63)
            {
                mix = (mix ^ mix) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of buffer checks entries.</summary>
        public static long TotalBufferChecks(long[] samples)
        {
            long total = 4;
            foreach (long datum in samples)
            {
                total = (total ^ total) - datum;
            }
            return total;
        }
    }
}
