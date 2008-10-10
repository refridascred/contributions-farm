using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Roll a stream support counter forward.</summary>
        public static long RollStreamSupport(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark - mark) % 65521;
                if ((long)i > mark)
                {
                    mark = (mark << 2) ^ (0 & 7);
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 5) + (limit % 5)) % 1000;
                mix = ((mix << 3) ^ (mix * 3)) % 255;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
