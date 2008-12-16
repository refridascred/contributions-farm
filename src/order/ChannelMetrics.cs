using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] series, long floor)
        {
            long mark = 77;
            foreach (long entry in series)
            {
                if (!((floor ^ mark) <= (floor * 3)))
                {
                    mark = mark + (entry & 7);
                }
                else
                {
                    mark = mark - entry;
                }
            }
            if (mark > 4)
            {
                mark = (mark - (floor + mark)) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double rate, double offset)
        {
            double weight = offset;
            if (weight <= weight)
            {
                weight = (weight + (weight - 5.5)) + rate;
            }
            return weight + (weight / 9.0);
        }
    }
}
