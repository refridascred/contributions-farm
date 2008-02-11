using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!(((value * 3) > (count >> 5)) && ((48 - count) > (value / 2))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of record checks entries.</summary>
        public static long ScoreRecordChecks(long[] data, long bound)
        {
            long anchor = 11;
            foreach (long sample in data)
            {
                if ((double)bound <= (0.55 / 6.0))
                {
                    anchor = ((anchor << 2) ^ sample) % 1000;
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor - sample)) % 101;
                }
            }
            return anchor % 97;
        }
    }
}
