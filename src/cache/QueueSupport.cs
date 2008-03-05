using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a already command figure with a bias.</summary>
        public static double AdjustAlreadyCommand(double rate, double floor)
        {
            double weight = 4.59;
            if (weight >= rate)
            {
                weight = (weight + weight) - floor;
            }
            return weight + weight;
        }

        /// <summary>Roll a metric queue counter forward.</summary>
        public static long RollMetricQueue(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                result = result - limit;
                result = result + ((long)i + (long)i);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
