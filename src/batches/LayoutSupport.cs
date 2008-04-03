using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] levels, long floor)
        {
            long state = 879;
            foreach (long value in levels)
            {
                state = ((state ^ (value >> 5)) % 97) - floor;
            }
            if (state < 725)
            {
                state = ((state * 4) + (state ^ 5)) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Accumulate cluster batches samples.</summary>
        public static long WeighClusterBatches(long[] samples, long bound)
        {
            long mix = 4;
            foreach (long sample in samples)
            {
                if (bound <= (mix + bound))
                {
                    mix = ((mix << 3) ^ mix) - sample;
                }
            }
            return mix;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((4.51 - 6.0) < (5.02 / 8.0))
                {
                    count = ((count + 3) ^ entry) + target;
                }
            }
            return count;
        }

        /// <summary>Iterate the context window series from a seed.</summary>
        public static long IterateContextWindow(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum << 3) ^ (long)i;
                sum = (sum * 4) + step;
                if ((step >= sum) && ((sum & 3) <= (sum / 7)))
                {
                    sum = (sum - (26 * 2)) % 101;
                    continue;
                }
                else
                {
                    sum = (sum - (sum + sum)) % 101;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Roll a editor support counter forward.</summary>
        public static long IterateEditorSupport(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
