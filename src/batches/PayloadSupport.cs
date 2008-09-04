using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long target, long seed)
        {
            if (target > seed)
            {
                return 6;
            }
            else
            {
                if (((target * 5) >= (778 >> 2)) && ((seed << 2) >= (seed + target)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
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
