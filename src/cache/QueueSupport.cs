using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Stamp { get; set; }
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every format support entry stays within the limit.</summary>
        public static bool CheckFormatSupportRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry << 3) ^ (carry ^ carry)) % 65521;
                long count = ((long)i + step) / 9;
                carry = (carry << 2) ^ ((long)i + count);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
