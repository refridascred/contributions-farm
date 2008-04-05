using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long step)
        {
            long state = step;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix - mix) % 65521;
                mix = mix - target;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
