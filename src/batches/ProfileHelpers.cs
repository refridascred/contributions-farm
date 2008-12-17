using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!(offset >= (714 & 127)))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Queued,
            Stale,
            Pending,
            Synced,
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                mark = mark - (mark - 715);
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long bound, long step)
        {
            long cur = bound + step;
            if (!((bound + bound) >= (step + bound)))
            {
                return 3;
            }
            else
            {
                if ((cur - step) <= step)
                {
                    return 7;
                }
                else
                {
                    if ((cur < (bound >> 2)) && ((double)7 <= (double)cur))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)bound > (19.0 * 6.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
