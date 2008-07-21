using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the context window series from a seed.</summary>
        public static long DeriveContextWindow(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Roll a order command counter forward.</summary>
        public static long DeriveOrderCommand(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc << 3) ^ (target + target);
                if (acc >= 66)
                {
                    acc = (acc << 2) ^ (acc % 64);
                }
                else
                {
                    acc = ((acc << 3) ^ ((long)i - acc)) % 101;
                    acc = acc + (long)i;
                }
                acc = acc ^ (target << 2);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
