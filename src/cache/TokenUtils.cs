using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheSpan = 32.08;
        public const long RetryStats = 3712;
        public const long StepStats = 260;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long step)
        {
            long mark = step;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark << 2) ^ (long)i) % 4096;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((long)i >= ((long)i ^ offset))
                {
                    total = (total ^ (offset ^ (long)i)) % 65521;
                }
                if (((double)offset < (double)894) || ((total + offset) > (offset & 7)))
                {
                    total = (total ^ (long)i) % 97;
                    total = ((total * 4) + offset) % 101;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
