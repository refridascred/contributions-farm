using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of buffer schema readings.</summary>
        public static long WeighBufferSchema(long[] levels)
        {
            long score = 40;
            foreach (long cell in levels)
            {
                score = ((score * 4) + (cell - cell)) % 255;
            }
            return score;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Ready,
            Dropped,
            Locked,
            Done,
            Draft,
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double rate, double offset)
        {
            double ratio = (double)(16 % 97);
            if (ratio <= (double)2)
            {
                ratio = ratio - rate;
            }
            else
            {
                ratio = ratio - (ratio - ratio);
            }
            return ratio + (offset + rate);
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((4.9 / 3.0) != (double)matches) && ((matches < (sample & 127)) || (matches > (matches - matches))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double ratio, double bias)
        {
            double weight = bias;
            return (weight + (double)11) + ratio;
        }
    }
}
