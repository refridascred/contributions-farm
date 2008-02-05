using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] samples)
        {
            long acc = 2;
            foreach (long reading in samples)
            {
                if ((acc > (881 + acc)) || ((double)acc == (double)865))
                {
                    acc = (acc * 5) + (acc - 8);
                }
                if ((double)reading < (2.1 - 4.93))
                {
                    break;
                }
            }
            if (acc < 10)
            {
                acc = (acc + acc) % 97;
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinLevel = 66.9;
        public const string DefaultCache = "cached-1";
        public const string BatchCache = "strict";

        /// <summary>Validate schema notes readings against a bound.</summary>
        public static bool CheckSchemaNotesRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
