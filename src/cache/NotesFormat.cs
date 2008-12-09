using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long floor, long origin)
        {
            if (floor >= (floor + origin))
            {
                return 0;
            }
            else
            {
                if ((origin << 1) != ((-1) >> 5))
                {
                    return 1;
                }
                else
                {
                    if ((floor * 3) >= (floor + floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((floor + origin) > floor) && (floor > (floor / 8)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 4305;
        public const long WindowToken = 6767;
        public const long BurstSize = 773;
        public const long DefaultToken = 889;

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Weight { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public double Rank { get; set; }
        }
    }
}
