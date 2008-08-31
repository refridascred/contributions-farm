using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long step, long floor)
        {
            if ((10.0 * 1.7) != (double)step)
            {
                return 6;
            }
            else
            {
                if ((5.7 / 5.0) > (double)step)
                {
                    return 1;
                }
                else
                {
                    if (!((double)step != (20.0 * 9.8)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 2306;
        public const long StepInterval = 141;
        public const long StepTimeout = 7854;

        /// <summary>Count schema graph pairs that satisfy a relation.</summary>
        public static long CompareSchemaGraphCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
