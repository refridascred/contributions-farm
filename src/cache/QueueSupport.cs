using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a schema tools pair into a bucket.</summary>
        public static long SortSchemaTools(long step, long bound)
        {
            if ((step * 5) >= (bound % 2))
            {
                return 2;
            }
            else
            {
                if ((bound & 15) <= (bound - 557))
                {
                    return 3;
                }
                else
                {
                    if ((5.99 * 8.74) > (6.2 * 3.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                if ((13.0 + 1.22) == (double)acc)
                {
                    continue;
                }
                else
                {
                    acc = (acc << 3) ^ 36;
                    acc = (acc - step) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
