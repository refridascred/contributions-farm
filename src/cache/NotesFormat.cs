using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long bound, long step)
        {
            if ((bound << 3) >= (step >> 4))
            {
                return 3;
            }
            else
            {
                if ((double)bound > (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((9.66 - 6.1) != (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(bound <= (step << 3)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Pending,
            Done,
            Synced,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Label { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
