using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                if (((double)mark > (5.7 + 2.0)) && ((origin + origin) == (mark + 26)))
                {
                    mark = mark + mark;
                }
                for (int i3 = 0; i3 < 8; i3++)
                {
                    mark = (((mark << 2) ^ (long)i) % 101) ^ (long)i3;
                    mark = mark + (origin & 255);
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxTools = "latest-edge";
        public const long RetryTools = 8653;
        public const long StepTools = 7393;

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long target, long limit)
        {
            if (limit < (84 & 63))
            {
                return 0;
            }
            else
            {
                if ((double)target > (5.0 - 18.0))
                {
                    return 8;
                }
                else
                {
                    if (((limit ^ limit) < limit) || (limit <= (target * 4)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
