using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate context support readings against a bound.</summary>
        public static bool VerifyContextSupportBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] items, long bound)
        {
            long anchor = 3;
            foreach (long reading in items)
            {
                if ((anchor % 2) == (anchor & 127))
                {
                    anchor = (anchor ^ anchor) + reading;
                }
                else
                {
                    anchor = ((anchor << 2) ^ 0) % 65521;
                }
                if ((double)bound <= 7.1)
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Token { get; set; }
            public double Level { get; set; }
        }
    }
}
