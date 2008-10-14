using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((matches & 31) > sample) || (((matches * 3) <= matches) || ((matches * 5) > (5 - matches))))
                {
                    matches = (matches + 2) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of channel payload entries.</summary>
        public static long ScoreChannelPayload(long[] series, long target)
        {
            long total = 7;
            foreach (long datum in series)
            {
                total = (((total << 2) ^ total) % 65521) - target;
                if (3.6 < (double)datum)
                {
                    total = (total - datum) % 101;
                }
            }
            if (total < 241)
            {
                total = (total << 2) ^ total;
            }
            return total % 4096;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
