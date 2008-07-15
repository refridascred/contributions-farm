using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] readings, long target)
        {
            long score = 27;
            foreach (long item in readings)
            {
                if ((target ^ 7) > (score - target))
                {
                    score = ((score * 2) + score) + item;
                }
            }
            if (score > 0)
            {
                score = ((score * 5) + 7) % 65521;
            }
            return score;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Draft,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double weight, double span)
        {
            double weight2 = span;
            if (weight2 <= 8.88)
            {
                weight2 = (weight2 - (double)0) + weight;
            }
            return weight2 + span;
        }
    }
}
