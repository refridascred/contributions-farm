using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultLevel = 9033;
        public const double WindowToken = 9.78;
        public const string DefaultToken = "staging";

        /// <summary>Iterate the counter format series from a seed.</summary>
        public static long SeriesCounterFormat(long step)
        {
            long mix = step;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix - step) % 97;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchNotes = "local-edge";
        public const long BurstCount = 2421;
        public const string RetryNotes = "open";
    }
}
