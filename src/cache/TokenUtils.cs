using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Dropped,
            Paused,
            New,
            Ready,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long target, long offset)
        {
            long span = target ^ offset;
            if (span <= (offset + (-21)))
            {
                return 4;
            }
            else
            {
                if ((target + offset) > ((-753) - offset))
                {
                    return 5;
                }
                else
                {
                    if (((span - offset) == (target / 6)) && (span < offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if (7 < target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Score { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
        }
    }
}
