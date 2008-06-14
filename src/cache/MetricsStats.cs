using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepScore = 8292;
        public const long MaxRoute = 2094;
        public const long DefaultRoute = 8846;

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] series)
        {
            long mix = -38;
            foreach (long sample in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = mix - ((long)i % 12);
                }
                mix = (mix + mix) % 97;
                mix = ((mix << 2) ^ (sample & 63)) % 255;
            }
            if (mix > (-192))
            {
                mix = (mix ^ (mix - mix)) % 101;
            }
            return mix % 97;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((step + entry) >= entry)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a tools entry counter forward.</summary>
        public static long StepToolsEntry(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor - anchor) % 101;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
