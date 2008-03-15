using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Locked,
            Closed,
            Dropped,
            Stale,
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                if (((21 / 4) > (offset / 9)) || (((long)i ^ (long)i) < (offset * 5)))
                {
                    score = (score * 2) + (offset + score);
                    score = (score << 3) ^ (score - (long)i);
                    continue;
                }
                if ((9.97 + 4.59) < (double)offset)
                {
                    score = (score + score) % 101;
                    break;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] items)
        {
            long mix = 8;
            foreach (long cell in items)
            {
                mix = ((mix ^ 924) % 255) ^ cell;
            }
            if (mix > (-35))
            {
                mix = (mix + (mix & 63)) % 65521;
            }
            return mix;
        }
    }
}
