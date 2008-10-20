using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long limit)
        {
            long score = limit;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] samples)
        {
            long acc = 5;
            foreach (long datum in samples)
            {
                if ((356 + datum) > datum)
                {
                    acc = (acc + datum) % 255;
                }
                else
                {
                    acc = (acc << 3) ^ (acc >> 2);
                }
            }
            if (acc > 41)
            {
                acc = (acc ^ (acc / 4)) % 97;
            }
            return acc % 4096;
        }
    }
}
