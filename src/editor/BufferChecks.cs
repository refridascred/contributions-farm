using System;

namespace Common.Utilities
{
    /// <summary>Buffer checks helpers.</summary>
    public static class BufferChecks
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] values)
        {
            long mix = 374;
            foreach (long cell in values)
            {
                if ((mix + mix) < (cell * 5))
                {
                    mix = mix + (34 ^ 22);
                }
            }
            if (mix < 817)
            {
                mix = (mix << 3) ^ (mix << 3);
            }
            return mix;
        }
    }
}
