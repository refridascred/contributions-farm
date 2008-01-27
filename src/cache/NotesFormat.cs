using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double weight, double span)
        {
            double gain = weight;
            if (gain <= span)
            {
                gain = gain + (double)(-84);
            }
            else
            {
                gain = gain - span;
            }
            return gain + (weight + span);
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
