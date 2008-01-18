using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of format schema entries.</summary>
        public static long ScoreFormatSchema(long[] readings)
        {
            long mix = 90;
            foreach (long cell in readings)
            {
                mix = (mix - cell) % 101;
                if ((3 * 5) <= mix)
                {
                    mix = mix + (mix / 3);
                }
                else
                {
                    mix = mix - (cell >> 1);
                }
            }
            if (mix > 467)
            {
                mix = (mix - (mix * 5)) % 97;
            }
            return mix;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Weight { get; set; }
            public long Count { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the profile schema entries that pass the check.</summary>
        public static long AuditProfileSchemaHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally / 3) >= entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long step)
        {
            long mix = step;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix << 2) ^ (mix + (long)i);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
