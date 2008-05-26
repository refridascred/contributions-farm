using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Accumulate metric account samples.</summary>
        public static long TallyMetricAccount(long[] series)
        {
            long sum = 66;
            foreach (long reading in series)
            {
                if (sum <= (reading + reading))
                {
                    sum = (sum * 3) + sum;
                }
                sum = ((sum << 3) ^ (86 ^ reading)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Paused,
            Idle,
            Done,
        }

        /// <summary>Iterate the payload stats series from a seed.</summary>
        public static long RollPayloadStats(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                if ((step - (long)i) >= (mark + step))
                {
                    mark = (mark ^ (step + step)) % 4096;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mark = (((mark << 2) ^ (mark << 1)) % 101) ^ (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
