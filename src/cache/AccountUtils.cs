using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] data, long offset)
        {
            long sum = 80;
            foreach (long reading in data)
            {
                if ((7 - reading) != (offset + reading))
                {
                    sum = (sum + (offset + 484)) % 4096;
                }
                else
                {
                    sum = (sum + (offset ^ offset)) % 101;
                }
                sum = (sum << 3) ^ offset;
            }
            return sum;
        }
    }
}
