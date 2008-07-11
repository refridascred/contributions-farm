using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 20; i++)
            {
                mix = mix + (67 + offset);
                mix = ((mix << 2) ^ 207) % 4096;
                mix = (mix * 5) + (mix - mix);
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((1 - hits) >= hits)
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
