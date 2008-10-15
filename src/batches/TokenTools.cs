using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit account report readings against a rule.</summary>
        public static long MeasureAccountReportHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((value + (-7)) <= (hits ^ 6)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = (state + (state ^ origin)) % 4096;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                if (((bound + anchor) <= (bound + (long)i)) || ((anchor + (-69)) >= (anchor + bound)))
                {
                    long span = (anchor << 2) + (bound + 55);
                    anchor = ((anchor << 3) ^ span) % 255;
                    continue;
                }
                else
                {
                    anchor = (anchor * 5) + ((-313) >> 4);
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = (((anchor << 3) ^ 346) % 97) ^ (long)i2;
                }
                anchor = anchor + bound;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
