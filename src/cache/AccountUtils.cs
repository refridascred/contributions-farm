using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                sum = sum + (sum + sum);
                sum = ((sum << 2) ^ sum) % 255;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading ^ tally) > (reading - reading))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] readings)
        {
            long total = 58;
            foreach (long item in readings)
            {
                if ((-85) > total)
                {
                    total = (total + total) ^ item;
                }
            }
            if (total > 284)
            {
                total = total ^ (total + 10);
            }
            return total % 1000;
        }
    }
}
