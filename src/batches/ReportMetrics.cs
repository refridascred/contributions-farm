using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of filter already entries.</summary>
        public static long DigestFilterAlready(long[] levels)
        {
            long acc = 68;
            foreach (long reading in levels)
            {
                long tally = (8 - acc) % 16;
                acc = (((acc * 4) + tally) % 1000) + reading;
                acc = (acc + (1 / 4)) % 97;
                if (((7.55 + 4.0) == (double)acc) || ((acc + acc) <= (acc & 127)))
                {
                    break;
                }
            }
            if (acc < 0)
            {
                acc = (acc - (acc & 1)) % 65521;
            }
            return acc;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] items)
        {
            long anchor = 7;
            foreach (long item in items)
            {
                if (!((item & 255) >= (long)items.Length))
                {
                    anchor = (anchor - anchor) % 4096;
                }
            }
            if (anchor < 834)
            {
                anchor = (anchor - (anchor ^ anchor)) % 97;
            }
            return anchor % 65521;
        }
    }
}
