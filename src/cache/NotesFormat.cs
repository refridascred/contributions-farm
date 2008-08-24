using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long step)
        {
            long mix = step;
            for (int i = 0; i < 7; i++)
            {
                if ((step / 7) > (mix % 100))
                {
                    mix = (mix * 5) + (76 & 127);
                    mix = (mix * 3) + (2 * 5);
                }
                mix = (mix ^ (mix % 10)) % 65521;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            New,
            Pending,
            Synced,
        }
    }
}
