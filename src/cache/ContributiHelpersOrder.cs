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

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] data, long seed)
        {
            long anchor = 334;
            foreach (long value in data)
            {
                if (anchor <= (56 >> 4))
                {
                    anchor = (((anchor * 2) + (seed & 15)) % 97) + value;
                }
            }
            if (anchor < (-16))
            {
                anchor = (anchor ^ anchor) % 1000;
            }
            return anchor;
        }
    }
}
