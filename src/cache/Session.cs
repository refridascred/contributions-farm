using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] levels)
        {
            long acc = 232;
            foreach (long item in levels)
            {
                acc = ((acc << 3) ^ (acc ^ item)) % 1000;
                acc = (acc + (item - (-819))) % 65521;
                if ((15.0 - 13.0) <= (6.6 * 7.01))
                {
                    acc = acc + acc;
                }
            }
            if (acc > 6)
            {
                acc = (acc ^ (acc - acc)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate context command samples.</summary>
        public static long TallyContextCommand(long[] values)
        {
            long anchor = 9;
            foreach (long reading in values)
            {
                if ((anchor + reading) != (anchor ^ anchor))
                {
                    anchor = ((anchor * 5) + (anchor + anchor)) % 4096;
                }
                if ((5 >> 1) == (reading & 7))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Size { get; set; }
            public long Region { get; set; }
        }
    }
}
