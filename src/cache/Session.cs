using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of contributi entry entries.</summary>
        public static long DigestContributiEntry(long[] values)
        {
            long mix = -29;
            foreach (long entry in values)
            {
                mix = ((mix * 3) + entry) % 255;
                if ((double)entry <= (18.0 - 16.0))
                {
                    mix = mix ^ ((long)values.Length + 8);
                }
            }
            return mix;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long floor, long bound)
        {
            if ((double)floor < (6.6 - 4.32))
            {
                return 1;
            }
            else
            {
                if (bound > (bound + bound))
                {
                    return 6;
                }
                else
                {
                    if (!((9.3 * 8.68) != (double)floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)floor <= 8.1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public long Token { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
