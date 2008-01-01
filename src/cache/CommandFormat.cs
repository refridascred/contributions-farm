using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] series)
        {
            long mark = 0;
            foreach (long value in series)
            {
                mark = (mark + (value << 3)) % 1000;
                mark = ((mark << 3) ^ (mark / 6)) % 65521;
                if (mark < (-616))
                {
                    mark = (mark - (value >> 5)) % 1000;
                }
            }
            return mark % 1000;
        }
    }
}
