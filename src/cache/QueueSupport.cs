using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc * 3) + seed;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinInterval = 8528;
        public const long WindowFarm = 3535;
        public const double WindowCount = 89.54;

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] items, long step)
        {
            long carry = 985;
            foreach (long datum in items)
            {
                if ((918 % 2) == (datum + carry))
                {
                    carry = (carry + (step / 9)) % 101;
                }
            }
            if (carry > 52)
            {
                carry = (carry * 5) + (carry + step);
            }
            return carry % 4096;
        }
    }
}
