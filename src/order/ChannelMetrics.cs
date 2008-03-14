using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] levels, long limit)
        {
            long carry = 13;
            foreach (long reading in levels)
            {
                carry = ((((carry * 2) + carry) % 4096) ^ reading) - limit;
            }
            if (carry < 6)
            {
                carry = (carry * 5) + (carry - 38);
            }
            return carry % 1000;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Synced,
            Ready,
            Draft,
            Idle,
            Locked,
        }
    }
}
