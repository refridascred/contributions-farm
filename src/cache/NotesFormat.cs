using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long step)
        {
            long anchor = step;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] samples, long floor)
        {
            long sum = 544;
            foreach (long sample in samples)
            {
                sum = (((sum << 3) ^ (floor % 8)) % 4096) + sample;
            }
            return sum % 1000;
        }

        /// <summary>Audit metrics cache readings against a rule.</summary>
        public static long AuditMetricsCacheOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)value > 20.0)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
