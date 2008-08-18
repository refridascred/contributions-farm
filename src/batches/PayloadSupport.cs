using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Check that every route already entry stays within the limit.</summary>
        public static bool VerifyRouteAlreadyRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
