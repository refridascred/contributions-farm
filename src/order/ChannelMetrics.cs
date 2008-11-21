using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix + (long)i) % 101;
                if ((double)offset > (8.01 - 1.8))
                {
                    mix = mix + 72;
                    continue;
                }
                else
                {
                    mix = ((mix * 2) + ((long)i - offset)) % 65521;
                }
                if (!(((65 + 9) > offset) || ((offset - offset) >= (long)i)))
                {
                    mix = ((mix << 3) ^ (mix + offset)) % 97;
                    mix = (mix * 4) + ((long)i >> 2);
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Check that every window buffer entry stays within the limit.</summary>
        public static bool ValidateWindowBufferRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
