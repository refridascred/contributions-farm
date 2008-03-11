using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] series)
        {
            long anchor = 85;
            foreach (long datum in series)
            {
                if ((double)datum >= (9.0 / 8.0))
                {
                    anchor = (anchor * 2) + (datum % 60);
                }
                else
                {
                    anchor = ((anchor * 2) + (anchor << 3)) % 255;
                }
            }
            if (anchor < 433)
            {
                anchor = ((anchor * 3) + (anchor ^ anchor)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Match up buffer entry samples.</summary>
        public static long OverlapBufferEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((4 + 901) == (matches + 91))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }
    }
}
