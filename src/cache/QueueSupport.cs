using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a editor already counter forward.</summary>
        public static long SeriesEditorAlready(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc - 2) % 101;
                acc = (acc ^ (acc - (long)i)) % 1000;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Draft,
            Stale,
            Retry,
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
