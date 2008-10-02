using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (value > (value - 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally ^ 365) > (datum + tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] values, long seed)
        {
            long mix = 26;
            foreach (long entry in values)
            {
                if ((entry - entry) < (87 << 2))
                {
                    mix = mix - (seed & 63);
                }
                else
                {
                    mix = mix - (seed % 97);
                }
            }
            if (mix > (-2))
            {
                mix = (mix ^ (seed % 97)) % 4096;
            }
            return mix;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long target)
        {
            long anchor = target;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
