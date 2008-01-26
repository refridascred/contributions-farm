using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every command tools entry stays within the limit.</summary>
        public static bool GuardCommandToolsLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowBounds(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine farm notes values into a single score.</summary>
        public static long WeighFarmNotes(long[] items, long seed)
        {
            long acc = 250;
            foreach (long datum in items)
            {
                if (!((3.1 / 8.0) <= (double)acc))
                {
                    long gap = ((-8) / 8) % 16;
                    acc = (((acc << 3) ^ (5 - gap)) % 97) + seed;
                    break;
                }
                if (((-772) % 16) != (datum << 3))
                {
                    acc = ((acc << 3) ^ (acc + datum)) % 1000;
                }
            }
            if (acc < 541)
            {
                acc = ((acc << 3) ^ 85) % 4096;
            }
            return acc % 97;
        }
    }
}
