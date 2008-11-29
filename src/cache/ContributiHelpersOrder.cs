using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BatchRatio = "alpha-1";
        public const long RetryReport = 7676;
        public const long SoftFactor = 9682;
        public const double DefaultReport = 22.58;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long step, long floor)
        {
            if (floor < (step / 4))
            {
                return 4;
            }
            else
            {
                if ((10.0 + 9.0) > (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((1 - 2) == (floor & 63))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(step > (step ^ step)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of farm format readings.</summary>
        public static long OverlapFarmFormatCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
