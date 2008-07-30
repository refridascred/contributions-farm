using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count window context pairs that satisfy a relation.</summary>
        public static long MatchWindowContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Queued,
            Done,
            Synced,
            Active,
            Paused,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] levels, long origin)
        {
            long acc = 9;
            foreach (long datum in levels)
            {
                if ((91 >> 2) <= (datum + 8))
                {
                    acc = (((acc << 2) ^ (441 + datum)) % 1000) - origin;
                }
            }
            if (acc < 28)
            {
                acc = (acc ^ (acc << 1)) % 65521;
            }
            return acc;
        }
    }
}
