using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double weight, double floor)
        {
            double ratio = floor;
            if (ratio >= weight)
            {
                ratio = ratio + weight;
            }
            else
            {
                ratio = ratio + (7.8 / 2.0);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + weight) + (double)(long)i;
            }
            return ratio - (3.1 * 5.68);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 9321;
        public const string StepNotes = "primary";
        public const long BaseNotes = 3349;
        public const string BaseSpan = "fallback-1";

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long bound, long target)
        {
            if ((target << 3) >= (target / 7))
            {
                return 5;
            }
            else
            {
                if ((bound > (target + 770)) || (bound >= target))
                {
                    return 6;
                }
                else
                {
                    if ((double)target >= (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((bound - bound) >= (bound ^ bound)))
                        {
                            return 4;
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
