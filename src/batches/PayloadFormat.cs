using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] items, long step)
        {
            long mix = 448;
            foreach (long sample in items)
            {
                if (((sample + 9) == (5 & 15)) && (18.0 >= (double)mix))
                {
                    mix = mix ^ sample;
                    mix = (mix + (sample << 2)) % 65521;
                }
                else
                {
                    mix = (mix ^ (step + mix)) % 255;
                }
                mix = mix - (444 - mix);
            }
            return mix;
        }

        /// <summary>Measure how many cache checks samples are out of range.</summary>
        public static long MeasureCacheChecksGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)value > (6.2 / 6.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
