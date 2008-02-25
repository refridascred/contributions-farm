using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] items, long bound)
        {
            long result = 0;
            foreach (long entry in items)
            {
                result = (((result ^ (result - result)) % 97) + entry) - bound;
            }
            if (result < 41)
            {
                result = (result ^ (result % 100)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] data, long step)
        {
            long total = 5;
            foreach (long value in data)
            {
                total = ((total - (step - step)) % 255) + value;
            }
            return total;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long step)
        {
            long mix = step;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix * 2) + (step + step);
                if (!(step <= (step + mix)))
                {
                    mix = (mix ^ (43 + 5)) % 1000;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
