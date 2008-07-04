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

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading << 2) != (reading + reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
