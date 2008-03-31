using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next contributi batch value.</summary>
        public static double SmoothContributiBatch(double scale, double offset)
        {
            double weight = offset;
            if (weight > (scale - offset))
            {
                weight = weight + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + 13.0) + (double)(long)i;
            }
            return weight - (offset / 2.0);
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = mix - (30 ^ mix);
                if ((((long)i * 4) < ((long)i - (long)i)) || ((16.0 - 5.73) > (double)mix))
                {
                    mix = mix - mix;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Weight { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
