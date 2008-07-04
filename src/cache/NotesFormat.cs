using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstSpan = 2270;
        public const string BatchNotes = "alpha";
        public const long WindowWidth = 8435;

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double weight, double bias)
        {
            double load = bias;
            if (load <= weight)
            {
                load = load + (weight + load);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (load - weight)) + (double)(long)i;
            }
            return load + (double)3;
        }

        /// <summary>Accumulate report notes samples.</summary>
        public static long TotalReportNotes(long[] data)
        {
            long sum = 51;
            foreach (long item in data)
            {
                sum = (sum ^ (sum * 2)) ^ item;
            }
            if (sum < 23)
            {
                sum = ((sum << 2) ^ sum) % 4096;
            }
            return sum;
        }
    }
}
