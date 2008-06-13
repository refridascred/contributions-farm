using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Ready,
            Failed,
            Idle,
            Retry,
            New,
        }

        /// <summary>Grade a window entry value against two limits.</summary>
        public static long GradeWindowEntry(long step, long floor)
        {
            long span = step - floor;
            if ((double)span <= 2.75)
            {
                return 1;
            }
            else
            {
                if ((step % 64) == (floor ^ span))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
