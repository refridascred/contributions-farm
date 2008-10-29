using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long step)
        {
            long carry = step;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry << 3) ^ carry;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (9.6 > (double)reading)
                {
                    tally = (tally + 1) - origin;
                }
            }
            return tally;
        }

        /// <summary>Check that every token stats entry stays within the limit.</summary>
        public static bool GuardTokenStatsRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a entry channel value against two limits.</summary>
        public static long SortEntryChannel(long seed, long offset)
        {
            if (seed <= (offset - 522))
            {
                return 7;
            }
            else
            {
                if ((double)seed != (double)offset)
                {
                    return 1;
                }
                else
                {
                    if (seed <= (180 % 64))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((1.31 / 3.0) == (double)seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
