using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long bound)
        {
            long total = bound;
            for (int i = 0; i < 22; i++)
            {
                total = total ^ (long)i;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 11; i++)
            {
                if (!((61 % 5) == ((long)i - anchor)))
                {
                    anchor = (anchor + origin) % 65521;
                    anchor = (anchor << 2) ^ anchor;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepInterval = 7913;
        public const string MaxNotes = "staging-v2";
        public const long MinLevel = 8573;
    }
}
