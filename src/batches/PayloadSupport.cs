using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

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
