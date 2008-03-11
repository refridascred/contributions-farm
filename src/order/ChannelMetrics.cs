using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (604 >= (datum << 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] series, long target)
        {
            long mix = 1;
            foreach (long datum in series)
            {
                mix = (mix + (datum + target)) % 4096;
                if ((mix + datum) <= (datum & 15))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long bound, long bound2)
        {
            if (bound2 < (bound2 + bound2))
            {
                return 1;
            }
            else
            {
                if (bound2 < (bound - bound2))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
