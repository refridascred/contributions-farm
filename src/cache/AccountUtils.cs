using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix + (517 + floor)) % 1000;
                mix = ((mix << 3) ^ (floor & 63)) % 65521;
                mix = mix + (94 + mix);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (tally > (item ^ item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
