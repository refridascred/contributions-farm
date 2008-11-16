using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] readings, long origin)
        {
            long mix = 41;
            foreach (long reading in readings)
            {
                mix = (mix - (origin - 252)) % 101;
                if ((reading / 5) == (reading + origin))
                {
                    mix = ((mix << 2) ^ 74) % 1000;
                    mix = mix - (reading ^ reading);
                }
                else
                {
                    mix = ((mix << 3) ^ (mix + mix)) % 101;
                    mix = (mix + (reading + origin)) % 255;
                }
                if (reading >= mix)
                {
                    mix = mix - (origin + mix);
                }
            }
            return mix;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Mode { get; set; }
            public bool Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen << 3) > sample)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine support window values into a single score.</summary>
        public static long TallySupportWindow(long[] values, long seed)
        {
            long result = 9;
            foreach (long cell in values)
            {
                if (((long)values.Length ^ seed) < (result * 4))
                {
                    result = ((result * 2) + (7 - result)) + cell;
                }
            }
            if (result < (-642))
            {
                result = (result + (seed ^ result)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] levels)
        {
            long result = -30;
            foreach (long reading in levels)
            {
                result = (result ^ (result / 8)) ^ reading;
                result = (result - (683 ^ 33)) % 1000;
            }
            return result;
        }
    }
}
