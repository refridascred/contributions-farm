using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the githubfarm layout series from a seed.</summary>
        public static long DeriveGithubfarmLayout(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = (total - ((long)i + 882)) % 65521;
                if (((long)i + offset) <= offset)
                {
                    total = ((total << 3) ^ (total * 4)) % 1000;
                }
                else
                {
                    total = total - (offset + 5);
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit token cache readings against a rule.</summary>
        public static long CountTokenCacheGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading >> 4) <= (reading ^ (-20)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
