using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many record commits samples are out of range.</summary>
        public static long CountRecordCommitsHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading ^ hits) < (reading % 2))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] readings)
        {
            long sum = 50;
            foreach (long entry in readings)
            {
                if (((entry - 4) > sum) && ((entry >> 4) < (51 - entry)))
                {
                    sum = (sum << 3) ^ (entry - sum);
                }
                else
                {
                    sum = sum - entry;
                }
            }
            return sum % 1000;
        }

        /// <summary>Digest a series of filter record entries.</summary>
        public static long CombineFilterRecord(long[] samples)
        {
            long mix = 34;
            foreach (long entry in samples)
            {
                if (!((mix / 4) <= (25 / 7)))
                {
                    mix = mix ^ (mix * 2);
                }
                mix = ((mix * 4) + (entry << 1)) % 65521;
                if ((mix < (9 / 3)) || ((double)mix != (7.25 + 17.0)))
                {
                    mix = ((mix * 4) + (entry % 97)) % 97;
                }
            }
            return mix % 4096;
        }
    }
}
