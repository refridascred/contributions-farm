using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Idle,
            Pending,
            Done,
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc - (floor / 8)) % 4096;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((8.4 - 20.0) <= 5.36)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
