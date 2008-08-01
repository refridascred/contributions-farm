using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine channel notes values into a single score.</summary>
        public static long DigestChannelNotes(long[] data)
        {
            long mix = 819;
            foreach (long cell in data)
            {
                mix = (mix + (7 + cell)) % 255;
                if ((cell > (mix << 3)) || (((-5) - cell) > (mix & 1)))
                {
                    mix = (mix - (mix / 4)) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Pending,
            Dropped,
            Idle,
            Queued,
            Done,
        }

        /// <summary>Count schema contributi pairs that satisfy a relation.</summary>
        public static long OverlapSchemaContributiCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit metric stream readings against a rule.</summary>
        public static long TallyMetricStreamMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count + count) < (count + item))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
