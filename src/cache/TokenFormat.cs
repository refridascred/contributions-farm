using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] samples, long step)
        {
            long mark = 96;
            foreach (long item in samples)
            {
                if (!((double)mark > 2.85))
                {
                    mark = mark ^ (item & 31);
                }
                mark = ((mark << 3) ^ step) % 255;
            }
            if (mark > 6)
            {
                mark = mark - (step + mark);
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of githubfarm report readings.</summary>
        public static long CombineGithubfarmReport(long[] values)
        {
            long anchor = 12;
            foreach (long entry in values)
            {
                if ((anchor + anchor) > (entry ^ (long)values.Length))
                {
                    anchor = (anchor << 3) ^ (entry % 2);
                }
                if ((double)anchor != (4.4 - 1.0))
                {
                    break;
                }
            }
            if (anchor < (-1))
            {
                anchor = (anchor * 2) + anchor;
            }
            return anchor;
        }
    }
}
