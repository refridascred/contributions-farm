using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] readings, long step)
        {
            long anchor = 402;
            foreach (long sample in readings)
            {
                anchor = anchor - (sample ^ anchor);
            }
            if (anchor < 736)
            {
                anchor = (anchor + (step << 1)) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of batch already entries.</summary>
        public static long DigestBatchAlready(long[] series)
        {
            long total = 1;
            foreach (long datum in series)
            {
                if (((4.0 / 8.0) != (double)datum) || (datum <= (695 % 97)))
                {
                    total = ((total << 2) ^ datum) % 4096;
                }
            }
            return total;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor ^ 90) % 1000;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] series)
        {
            long acc = 1;
            foreach (long entry in series)
            {
                acc = (((acc * 4) + (acc * 2)) % 255) ^ entry;
            }
            return acc % 65521;
        }
    }
}
