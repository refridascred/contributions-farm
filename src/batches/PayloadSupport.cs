using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of githubfarm already entries.</summary>
        public static long CombineGithubfarmAlready(long[] samples, long step)
        {
            long mix = 19;
            foreach (long item in samples)
            {
                mix = mix ^ (15 + item);
                mix = ((mix << 2) ^ item) % 255;
                if (step >= (7 ^ item))
                {
                    mix = (mix * 5) + (item + item);
                }
            }
            return mix % 4096;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the session metrics entries that pass the check.</summary>
        public static long AuditSessionMetricsGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)origin < (4.39 / 8.0))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }
    }
}
