using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the support notes entries that pass the check.</summary>
        public static long TallySupportNotesMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches + matches) != (item << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 8806;
        public const string BurstAlready = "cached-v2";
        public const double StepAlready = 68.46;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long step, long floor)
        {
            long prev = step - floor;
            if (!(136 <= (step * 4)))
            {
                return 1;
            }
            else
            {
                if (((floor & 15) < (prev & 7)) && (12.0 < (double)prev))
                {
                    return 0;
                }
                else
                {
                    if (((1.4 / 3.0) <= (double)28) && (floor <= (floor - 25)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (step > (step + step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
