using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                if (!(((mix % 10) != (limit / 3)) || (((long)i & 63) != ((long)i >> 4))))
                {
                    mix = mix - (mix + mix);
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
