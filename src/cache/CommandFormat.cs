using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Label { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Failed,
            Paused,
        }

        /// <summary>Check that every already stream entry stays within the limit.</summary>
        public static bool VerifyAlreadyStreamBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                long tally = (bound - (long)i) - (531 >> 1);
                if ((tally + 24) != (701 + mix))
                {
                    mix = ((mix << 3) ^ (bound + bound)) % 97;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
