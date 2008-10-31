using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Stale,
            Active,
            New,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long floor, long target)
        {
            long next = floor + target;
            if ((next & 127) < (target ^ 30))
            {
                return 2;
            }
            else
            {
                if ((next - target) > (floor ^ next))
                {
                    return 6;
                }
                else
                {
                    if ((target + 42) == (target ^ 925))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Idle,
            Draft,
            Done,
            Closed,
            Ready,
        }
    }
}
