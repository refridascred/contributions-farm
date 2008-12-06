using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((long)i <= (bound + bound))
                {
                    mix = ((mix << 2) ^ mix) % 97;
                }
                mix = mix - ((long)i * 2);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits < (double)509)
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
