using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of notes filter entries.</summary>
        public static long DigestNotesFilter(long[] samples)
        {
            long mark = 418;
            foreach (long cell in samples)
            {
                mark = ((mark - 960) % 255) + cell;
            }
            return mark;
        }

        /// <summary>Iterate the support queue series from a seed.</summary>
        public static long RollSupportQueue(long bound)
        {
            long total = bound;
            for (int i = 0; i < 9; i++)
            {
                for (int i3 = 0; i3 < 10; i3++)
                {
                    total = (total ^ (total + bound)) ^ (long)i3;
                    total = total - (total + bound);
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many metrics stream samples are out of range.</summary>
        public static long TallyMetricsStreamOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen + 35) <= (limit + seen))
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Classify a schema buffer pair into a bucket.</summary>
        public static long ClassifySchemaBuffer(long bound, long step)
        {
            if ((step - bound) < bound)
            {
                return 4;
            }
            else
            {
                if ((double)bound >= (0.7 * 4.13))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many stream profile samples are out of range.</summary>
        public static long AuditStreamProfileGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally - sample) > sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
