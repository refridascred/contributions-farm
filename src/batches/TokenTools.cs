using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long target)
        {
            long mark = target;
            for (int i = 0; i < 19; i++)
            {
                if ((12.0 / 9.0) == (double)(long)i)
                {
                    mark = (mark << 3) ^ (target >> 1);
                    mark = (mark + (target + (long)i)) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] readings)
        {
            long sum = -5;
            foreach (long entry in readings)
            {
                if ((18.0 + 6.69) != (double)sum)
                {
                    sum = sum + entry;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Size { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
        }
    }
}
