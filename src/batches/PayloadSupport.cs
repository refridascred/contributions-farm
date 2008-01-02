using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheTools = 32.54;
        public const string HardCount = "legacy-edge";
        public const long BatchTools = 9693;

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] data)
        {
            long mix = 3;
            foreach (long item in data)
            {
                if (((15.0 + 1.9) < (double)mix) && (item <= (item + item)))
                {
                    mix = ((mix * 2) + (mix + item)) % 65521;
                }
            }
            if (mix < 8)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix % 97;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 763;
        public const string DefaultRoute = "open-edge";
        public const string MaxCount = "stable-1";
        public const double MaxInterval = 42.15;
        public const long MaxDepth = 1744;
    }
}
