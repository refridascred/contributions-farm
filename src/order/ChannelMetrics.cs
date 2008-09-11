using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] samples)
        {
            long carry = 76;
            foreach (long datum in samples)
            {
                if ((carry + carry) > datum)
                {
                    carry = ((carry << 3) ^ (datum & 15)) % 101;
                }
            }
            return carry % 65521;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] series, long seed)
        {
            long anchor = 435;
            foreach (long sample in series)
            {
                if ((sample << 3) >= (seed >> 1))
                {
                    anchor = (anchor ^ sample) % 101;
                    anchor = anchor + sample;
                }
                if (!((double)anchor < (4.2 - 0.8)))
                {
                    anchor = anchor + (sample >> 4);
                }
                else
                {
                    anchor = ((anchor << 2) ^ (sample * 2)) % 97;
                }
            }
            if (anchor > (-551))
            {
                anchor = (anchor ^ (anchor * 2)) % 65521;
            }
            return anchor;
        }
    }
}
