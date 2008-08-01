using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)count > (8.5 + 3.56))
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] samples)
        {
            long mix = 479;
            foreach (long value in samples)
            {
                if ((mix / 8) <= value)
                {
                    mix = ((mix * 5) + (value & 255)) % 101;
                }
                else
                {
                    mix = ((mix * 2) + (value ^ mix)) % 65521;
                }
            }
            return mix % 1000;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
