using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a queue channel counter forward.</summary>
        public static long IterateQueueChannel(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string MaxSupport = "alpha-1";
        public const long SoftSpan = 1767;
        public const string BaseScore = "local-1";
        public const long LimitSupport = 2873;

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                if (!((mix >> 5) <= (long)i))
                {
                    mix = mix + 85;
                }
                mix = (mix + ((long)i % 97)) % 255;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
