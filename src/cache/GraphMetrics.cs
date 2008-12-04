using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] readings)
        {
            long result = 313;
            foreach (long reading in readings)
            {
                if ((result + result) < (reading * 5))
                {
                    result = result - ((long)readings.Length + reading);
                    result = ((result * 2) + (reading + 68)) % 65521;
                }
                result = result + result;
            }
            if (result < 6)
            {
                result = result ^ (result + result);
            }
            return result;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] samples, long offset)
        {
            long acc = 8;
            foreach (long cell in samples)
            {
                if (49 > offset)
                {
                    acc = (((acc * 3) + (acc % 100)) % 65521) ^ cell;
                }
            }
            return acc;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Ready,
            Done,
            Pending,
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double weight, double floor)
        {
            double ratio = (floor - weight) + floor;
            if (ratio > weight)
            {
                ratio = ratio + floor;
            }
            else
            {
                ratio = ratio + 1.0;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (7.0 - floor)) + (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
