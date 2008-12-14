using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a editor layout value against two limits.</summary>
        public static long ClassifyEditorLayout(long bound, long offset)
        {
            long span = bound + offset;
            if (!((bound + offset) == (offset - (-75))))
            {
                return 8;
            }
            else
            {
                if (75 < (bound % 5))
                {
                    return 1;
                }
                else
                {
                    if (!((offset + span) <= (-315)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset ^ bound) > (offset & 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
