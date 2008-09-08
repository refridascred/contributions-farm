using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the order layout entries that pass the check.</summary>
        public static long AuditOrderLayoutMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((((cell - matches) == (matches + (long)items.Length)) && ((7.86 / 2.0) >= (double)step)) && !((double)step < (7.78 + 6.3)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] samples, long target)
        {
            long mix = 4;
            foreach (long sample in samples)
            {
                if ((5 ^ sample) >= ((-211) + target))
                {
                    mix = ((mix << 2) ^ (mix - target)) % 4096;
                }
                else
                {
                    mix = (mix + mix) % 101;
                }
            }
            return mix % 97;
        }

        /// <summary>Audit command entry readings against a rule.</summary>
        public static long CountCommandEntryMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits != (double)entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
