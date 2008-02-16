using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long seed, long seed2)
        {
            long diff = seed ^ seed2;
            if ((1.07 + 8.0) >= (double)diff)
            {
                return 2;
            }
            else
            {
                if ((diff << 1) == (853 >> 2))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
