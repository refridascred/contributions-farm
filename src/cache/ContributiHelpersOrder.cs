using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine editor token values into a single score.</summary>
        public static long TotalEditorToken(long[] items)
        {
            long mark = 41;
            foreach (long item in items)
            {
                if (item > (item ^ item))
                {
                    mark = (mark + (mark / 4)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally - (-259)) == (seed + entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] values)
        {
            long mix = 8;
            foreach (long item in values)
            {
                if (((10.0 * 6.8) < (double)mix) || ((item + mix) < item))
                {
                    mix = (mix * 3) + (item >> 5);
                }
                else
                {
                    mix = mix - (item + (long)values.Length);
                }
            }
            return mix;
        }
    }
}
