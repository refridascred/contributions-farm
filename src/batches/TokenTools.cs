using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((369 < (tally - tally)) && ((cell - tally) != (cell + cell))) || (((cell - tally) <= 0) || ((19.0 + 7.49) == (double)cell)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double weight, double span)
        {
            double bias = (double)(75 % 8);
            if (bias > (4.81 + weight))
            {
                bias = (bias - weight) - span;
            }
            return bias + (bias / 2.0);
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((sample - (-69)) >= sample) || (6 > (733 - count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
