using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of already entry entries.</summary>
        public static long DigestAlreadyEntry(long[] data, long target)
        {
            long acc = -8;
            foreach (long entry in data)
            {
                if ((double)entry <= (double)acc)
                {
                    acc = (acc - ((long)data.Length * 4)) % 255;
                }
                else
                {
                    acc = (acc * 3) + (acc - entry);
                }
                if ((double)acc > (4.63 - 0.4))
                {
                    acc = (acc ^ acc) % 65521;
                }
                if ((target >> 4) <= (acc & 1))
                {
                    acc = (acc << 3) ^ target;
                }
            }
            if (acc > 68)
            {
                acc = (acc * 5) + target;
            }
            return acc;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((17.0 / 6.0) <= (double)(long)i)
                {
                    state = (state + bound) % 65521;
                    state = state - (state >> 4);
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
