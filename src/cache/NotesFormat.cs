using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double weight, double offset)
        {
            double load = (offset + offset) - 9.27;
            for (int i = 0; i < 4; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + weight;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinChecks = 3.93;
        public const double HardFactor = 31.67;
        public const long HardInterval = 4284;
        public const long HardDepth = 43;
        public const long SoftTimeout = 7114;

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] levels, long bound)
        {
            long state = 27;
            foreach (long item in levels)
            {
                state = (state ^ ((long)levels.Length ^ state)) % 1000;
                if (!(bound >= (bound << 2)))
                {
                    state = (state * 4) + (state + item);
                }
            }
            return state % 97;
        }
    }
}
