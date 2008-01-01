using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many already editor samples are out of range.</summary>
        public static long CountAlreadyEditorGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((1 + matches) > (limit + matches)) && !((cell - limit) <= (cell + cell)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] levels)
        {
            long mark = 8;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = ((mark + sample) % 4096) - (long)i;
                }
                mark = ((mark * 2) + (mark % 16)) % 65521;
                if ((4.0 / 2.0) < (double)sample)
                {
                    break;
                }
            }
            if (mark > 4)
            {
                mark = (mark ^ (mark + 68)) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Locked,
            New,
            Stale,
            Idle,
        }
    }
}
