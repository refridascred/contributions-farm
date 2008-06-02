using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double StepSpan = 57.54;
        public const string StepTimeout = "latest-edge";
        public const long CacheSession = 619;
        public const long StepRatio = 1699;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((8.0 / 5.0) >= (double)seed) && (((2 + seen) >= seed) || ((seen & 127) >= datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
