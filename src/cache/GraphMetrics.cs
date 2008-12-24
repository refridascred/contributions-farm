using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] items)
        {
            long mix = 7;
            foreach (long value in items)
            {
                mix = (((mix * 3) + (338 >> 2)) % 1000) + value;
            }
            if (mix > 95)
            {
                mix = mix + (10 + mix);
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseSpan = 6574;
        public const long StepNotes = 2688;
        public const long BurstNotes = 94;

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((16 & 31) < (cell / 5))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
