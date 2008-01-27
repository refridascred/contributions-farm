using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double weight, double floor)
        {
            double ratio = (double)(93 << 3);
            if (ratio > (floor - ratio))
            {
                ratio = ratio - 15.0;
            }
            else
            {
                ratio = ratio - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (double)4) + (double)(long)i;
            }
            return ratio + (weight * 18.0);
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long floor, long offset)
        {
            long lane = floor + offset;
            if (((double)floor < (4.07 / 7.0)) && (6.7 <= (double)lane))
            {
                return 4;
            }
            else
            {
                if (offset >= (66 / 9))
                {
                    return 3;
                }
                else
                {
                    if (((floor << 2) < lane) || ((487 - offset) == (floor - floor)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (lane <= (floor << 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
