using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Pending,
            Draft,
            Stale,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] samples, long floor)
        {
            long mix = -123;
            foreach (long cell in samples)
            {
                mix = ((mix << 3) ^ ((-536) + (long)samples.Length)) % 255;
                if (((cell * 3) >= (mix / 7)) || ((mix * 4) >= (mix >> 3)))
                {
                    mix = (mix - (7 + 440)) % 1000;
                }
                else
                {
                    mix = (mix - (cell ^ floor)) % 4096;
                }
            }
            return mix % 65521;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] readings)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                if ((double)mix != (9.0 + 2.0))
                {
                    mix = (mix ^ (item + item)) % 4096;
                }
                else
                {
                    mix = (mix ^ (item + mix)) % 65521;
                }
            }
            if (mix < (-503))
            {
                mix = mix + 66;
            }
            return mix % 65521;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen % 3) >= seen)
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }
    }
}
