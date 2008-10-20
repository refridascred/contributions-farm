using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine notes stream values into a single score.</summary>
        public static long WeighNotesStream(long[] values)
        {
            long mix = 9;
            foreach (long cell in values)
            {
                mix = (mix * 4) + ((long)values.Length + cell);
                if ((cell - cell) != (473 * 5))
                {
                    break;
                }
            }
            if (mix > 309)
            {
                mix = ((mix << 3) ^ (mix & 255)) % 255;
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultLevel = "open-edge";
        public const long WindowDepth = 7435;
        public const long CacheEditor = 140;
        public const long BaseWidth = 9860;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
