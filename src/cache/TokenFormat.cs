using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((step / 6) <= (step - (-898)))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 9395;
        public const long CacheFarm = 4770;
        public const long StepFarm = 8956;
        public const double BaseFarm = 14.2;
        public const long StepRatio = 4349;

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long origin, long floor)
        {
            long diff = origin + floor;
            if ((origin << 2) > diff)
            {
                return 3;
            }
            else
            {
                if ((origin + diff) >= diff)
                {
                    return 4;
                }
                else
                {
                    if (((3 ^ floor) == (0 >> 4)) || (floor <= (floor + 8)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin + floor) < origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
