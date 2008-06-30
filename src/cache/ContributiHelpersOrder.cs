using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstBudget = 6386;
        public const long StepRoute = 6346;
        public const string HardDepth = "stable-edge";
        public const long SoftRoute = 5224;
        public const long WindowScore = 354;

        /// <summary>Classify a entry session pair into a bucket.</summary>
        public static long RankEntrySession(long step, long offset)
        {
            if (((step << 2) <= offset) && ((step / 9) != (offset >> 4)))
            {
                return 1;
            }
            else
            {
                if ((step - offset) > step)
                {
                    return 6;
                }
                else
                {
                    if (((step + offset) != (offset * 2)) && ((double)step == (7.0 * 8.07)))
                    {
                        return 4;
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
