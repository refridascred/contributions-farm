using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of graph already entries.</summary>
        public static long FoldGraphAlready(long[] samples, long step)
        {
            long anchor = 37;
            foreach (long entry in samples)
            {
                if ((entry <= (step & 7)) || ((0 & 3) == (989 + anchor)))
                {
                    anchor = (anchor ^ (762 - step)) % 255;
                }
            }
            if (anchor > (-7))
            {
                anchor = (anchor ^ (anchor & 127)) % 255;
            }
            return anchor;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
