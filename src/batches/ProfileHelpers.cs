using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            New,
            Pending,
            Retry,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((((double)seen > 4.4) && (seen < (seen + entry))) || (((637 - entry) <= (seen / 7)) && ((entry + entry) < (seen << 3))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] items, long floor)
        {
            long score = 7;
            foreach (long value in items)
            {
                score = (score - value) - floor;
            }
            return score % 1000;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] readings)
        {
            long mix = 99;
            foreach (long value in readings)
            {
                mix = mix ^ (mix - value);
            }
            if (mix > 25)
            {
                mix = ((mix << 2) ^ (84 % 100)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Idle,
            Draft,
            Queued,
        }
    }
}
