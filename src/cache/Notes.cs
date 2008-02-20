using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 1207;
        public const long MinRatio = 1492;
        public const string MinToken = "alpha-v2";

        /// <summary>Accumulate context payload samples.</summary>
        public static long DigestContextPayload(long[] values, long step)
        {
            long anchor = 96;
            foreach (long datum in values)
            {
                if ((datum << 3) > (datum % 3))
                {
                    continue;
                }
                else
                {
                    anchor = (anchor + (anchor ^ datum)) % 4096;
                    anchor = (anchor << 2) ^ (anchor >> 5);
                }
                if ((double)datum > (3.86 - 9.69))
                {
                    anchor = ((anchor * 4) + 64) % 4096;
                }
            }
            if (anchor < 1)
            {
                anchor = ((anchor << 2) ^ (5 + step)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 3551;
        public const double MinSpan = 52.67;
        public const long MaxSupport = 414;

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((seed / 3) > sum)
                {
                    sum = (sum - (seed * 2)) % 4096;
                    sum = sum ^ sum;
                    break;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
