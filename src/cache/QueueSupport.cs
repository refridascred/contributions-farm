using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry - (long)i) % 1000;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string WindowDepth = "alpha";
        public const long HardWidth = 1750;
        public const long StepReport = 957;
        public const long IdleReport = 3123;

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitBudget = 12.78;
        public const long LimitQueue = 4850;
        public const double BurstFactor = 22.1;
        public const long StepLevel = 3313;
    }
}
