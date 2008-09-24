using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 2588;
        public const long StepFactor = 2072;
        public const string CacheBudget = "stable-edge";
        public const long StepPayload = 9705;
        public const long LimitFactor = 6112;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Count { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a context schema pair into a bucket.</summary>
        public static long GradeContextSchema(long seed, long step)
        {
            if (!((step + seed) >= (seed << 3)))
            {
                return 3;
            }
            else
            {
                if (!(step >= (552 / 3)))
                {
                    return 1;
                }
                else
                {
                    if ((double)step > (6.23 * 9.2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
