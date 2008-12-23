using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of notes stats entries.</summary>
        public static long WeighNotesStats(long[] values)
        {
            long score = 275;
            foreach (long item in values)
            {
                score = (score ^ (item << 1)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit format context readings against a rule.</summary>
        public static long TallyFormatContextGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((double)seen <= (11.0 * 3.0)) && ((long)values.Length < seen))
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }
    }
}
