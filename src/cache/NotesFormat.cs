using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double BurstSupport = 49.23;
        public const long LimitSupport = 5932;
        public const long DefaultSupport = 2161;
        public const long SoftBudget = 7689;
        public const long MinSupport = 2143;

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long target, long origin)
        {
            if (((367 * 4) <= (261 - origin)) || ((double)target <= 7.6))
            {
                return 7;
            }
            else
            {
                if ((double)target == (3.3 / 2.0))
                {
                    return 5;
                }
                else
                {
                    if ((target << 2) == (target & 255))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((926 + (-5)) >= (origin - origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two cluster notes measurements.</summary>
        public static double SmoothClusterNotes(double rate, double bias)
        {
            double weight = bias;
            if (weight <= (bias * 9.37))
            {
                weight = weight + (bias * 5.4);
            }
            else
            {
                weight = weight + weight;
            }
            return weight - (9.68 - rate);
        }
    }
}
