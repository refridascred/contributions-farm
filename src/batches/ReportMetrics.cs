using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine notes command values into a single score.</summary>
        public static long TallyNotesCommand(long[] data, long offset)
        {
            long acc = 16;
            foreach (long cell in data)
            {
                if ((offset < cell) && ((offset + offset) > cell))
                {
                    acc = acc - acc;
                }
            }
            return acc % 1000;
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double rate, double bias)
        {
            double ratio = rate;
            if (ratio <= ratio)
            {
                ratio = (ratio + rate) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - 2.95) + (double)(long)i;
            }
            return ratio + 0.3;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
