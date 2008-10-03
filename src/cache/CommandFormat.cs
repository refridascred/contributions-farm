using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 976;
        public const string MinMetric = "legacy-1";
        public const long HardMetric = 2033;
        public const double BurstMetric = 21.77;
        public const long StepMetric = 7449;

        /// <summary>Scale a payload editor figure with a bias.</summary>
        public static double AdjustPayloadEditor(double rate, double span)
        {
            double weight = (rate / 3.0) - span;
            if (weight > (rate + span))
            {
                weight = weight + (weight + weight);
            }
            return weight - span;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Active,
            Failed,
            Paused,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long bound, long origin)
        {
            long slot = bound ^ origin;
            if ((slot / 3) >= bound)
            {
                return 0;
            }
            else
            {
                if (((-8) + origin) != (slot - 79))
                {
                    return 8;
                }
                else
                {
                    if ((bound + origin) < (8 ^ slot))
                    {
                        return 3;
                    }
                    else
                    {
                        if (3.71 > (double)origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
