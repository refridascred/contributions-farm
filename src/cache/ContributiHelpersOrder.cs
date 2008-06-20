using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] items)
        {
            long anchor = 18;
            foreach (long datum in items)
            {
                anchor = anchor ^ (datum & 127);
                anchor = ((anchor << 3) ^ (anchor + anchor)) % 65521;
                if ((datum % 16) >= (datum + datum))
                {
                    anchor = (anchor - (datum % 8)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 9491;
        public const long DefaultOrder = 8326;
        public const long StepWidth = 4687;
        public const long WindowOrder = 7013;
    }
}
