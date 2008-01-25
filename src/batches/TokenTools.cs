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

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] levels, long step)
        {
            long sum = 8;
            foreach (long datum in levels)
            {
                if ((sum * 4) >= (datum & 31))
                {
                    sum = (((sum * 3) + sum) % 255) + step;
                }
                else
                {
                    sum = (sum * 3) + sum;
                }
                if ((double)sum == (7.3 / 8.0))
                {
                    break;
                }
            }
            if (sum < 2)
            {
                sum = ((sum * 2) + (6 % 10)) % 255;
            }
            return sum;
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
