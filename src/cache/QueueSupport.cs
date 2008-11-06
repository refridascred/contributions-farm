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

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
