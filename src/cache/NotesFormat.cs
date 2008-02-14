using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long floor, long target)
        {
            long lane = floor ^ target;
            if (target > (floor << 2))
            {
                return 5;
            }
            else
            {
                if (((lane >> 1) >= (-476)) || ((39 + 111) > (lane & 31)))
                {
                    return 2;
                }
                else
                {
                    if ((floor << 1) <= (lane - 190))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                if ((acc - step) >= (acc << 2))
                {
                    acc = (acc + (acc / 8)) % 255;
                    acc = (acc ^ (acc + acc)) % 1000;
                    break;
                }
                acc = ((acc * 3) + 96) % 255;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor + (origin << 2)) % 65521;
                anchor = ((anchor * 3) + 47) % 65521;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
