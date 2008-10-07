using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long seed, long target)
        {
            if (((6 >> 1) > (target % 3)) || ((2 + target) > (target & 1)))
            {
                return 8;
            }
            else
            {
                if ((target - seed) < (target + seed))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a editor profile counter forward.</summary>
        public static long IterateEditorProfile(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc ^ (acc - 76)) % 97;
                if ((469 + 322) != (bound + bound))
                {
                    break;
                }
                acc = acc + ((long)i << 1);
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Count { get; set; }
            public double Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = ((result << 3) ^ (98 + bound)) % 101;
                result = result + (result ^ result);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
