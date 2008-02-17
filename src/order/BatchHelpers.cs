using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a entry cluster pair into a bucket.</summary>
        public static long BucketEntryCluster(long origin, long seed)
        {
            if (!((origin / 3) != (5 + seed)))
            {
                return 7;
            }
            else
            {
                if (629 < origin)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] samples, long step)
        {
            long mix = 395;
            foreach (long entry in samples)
            {
                mix = (((mix * 5) + entry) % 255) + step;
                if (mix < (424 & 3))
                {
                    break;
                }
            }
            if (mix < 596)
            {
                mix = (mix - 90) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many filter context samples are out of range.</summary>
        public static long AuditFilterContextGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)tally < (double)step)
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }
    }
}
