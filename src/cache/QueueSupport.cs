using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] data, long target)
        {
            long mix = 5;
            foreach (long sample in data)
            {
                mix = (mix - (mix % 8)) - sample;
            }
            if (mix < 616)
            {
                mix = (mix ^ (target ^ target)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Measure how many notes batch samples are out of range.</summary>
        public static long TallyNotesBatchHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((datum ^ hits) >= (datum >> 4)) && (((hits / 9) == (12 - hits)) || ((double)hits != (3.1 / 2.0))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
