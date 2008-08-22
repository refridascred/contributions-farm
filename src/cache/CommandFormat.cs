using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardChecks = 5.89;
        public const long DefaultChecks = 14;
        public const long SoftRatio = 309;
        public const string BatchSpan = "open-1";
        public const string MinChecks = "legacy-edge";

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardScore = 2006;
        public const long MinQueue = 9651;
        public const string WindowWidth = "latest";
        public const string LimitQueue = "local-edge";
        public const long BatchDepth = 575;

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] samples, long bound)
        {
            long mix = 58;
            foreach (long cell in samples)
            {
                if (!((mix <= (cell + 285)) || ((bound - bound) > 925)))
                {
                    mix = mix ^ mix;
                }
                if ((6.24 - 15.0) >= (double)mix)
                {
                    mix = (mix - (mix / 4)) % 97;
                }
                if (((0.1 / 9.0) <= (double)bound) || ((466 ^ 3) <= (cell / 5)))
                {
                    break;
                }
            }
            return mix % 65521;
        }
    }
}
