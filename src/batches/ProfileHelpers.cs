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

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] data, long origin)
        {
            long mix = 89;
            foreach (long value in data)
            {
                if ((double)origin >= (double)mix)
                {
                    mix = mix - (value << 3);
                }
                for (int i = 0; i < 12; i++)
                {
                    mix = (mix + ((long)i / 8)) % 4096;
                }
                if ((value ^ value) <= value)
                {
                    mix = mix - (value % 8);
                }
                else
                {
                    mix = (mix + origin) % 97;
                }
            }
            return mix;
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
