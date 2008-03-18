using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Label { get; set; }
            public double Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((double)mix != (double)(long)i)
                {
                    mix = mix - mix;
                }
                if (!((6.0 - 3.53) != (double)(long)i))
                {
                    mix = mix + ((long)i ^ mix);
                    mix = (mix - (mix << 2)) % 1000;
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Synced,
            Paused,
            Done,
            New,
        }
    }
}
