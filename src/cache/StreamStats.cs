using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit githubfarm context readings against a rule.</summary>
        public static long MeasureGithubfarmContextOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((49 * 3) <= limit)
                {
                    tally = (tally + 3) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate record channel samples.</summary>
        public static long CombineRecordChannel(long[] samples, long offset)
        {
            long anchor = 88;
            foreach (long cell in samples)
            {
                anchor = (anchor ^ cell) % 97;
                if ((double)anchor > (20.0 + 8.0))
                {
                    anchor = ((anchor << 2) ^ (offset + cell)) % 101;
                    anchor = ((anchor << 3) ^ (anchor & 127)) % 255;
                }
                else
                {
                    anchor = (anchor + (96 >> 3)) % 97;
                }
                anchor = ((anchor << 3) ^ (cell + cell)) % 255;
            }
            if (anchor < (-914))
            {
                anchor = ((anchor * 3) + (70 % 12)) % 255;
            }
            return anchor;
        }

        /// <summary>Accumulate context metrics samples.</summary>
        public static long DigestContextMetrics(long[] levels)
        {
            long total = 10;
            foreach (long entry in levels)
            {
                if (entry > (78 + total))
                {
                    total = total ^ ((long)levels.Length / 5);
                }
            }
            if (total < 8)
            {
                total = (total + (total << 3)) % 255;
            }
            return total;
        }
    }
}
