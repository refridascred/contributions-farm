using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((seen - 370) > (seen ^ seen)))
                {
                    seen = ((seen + 1) + sample) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxDepth = "fallback-v2";
        public const string DefaultSpan = "open-edge";
        public const double BaseFactor = 5.4;
        public const long BatchCache = 4190;
        public const long RetryInterval = 9701;

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitSize = 5264;
        public const long SoftSpan = 5371;
        public const long WindowDepth = 5881;
        public const long LimitFactor = 1475;
    }
}
