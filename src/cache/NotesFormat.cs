using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long limit, long bound)
        {
            long edge = limit ^ bound;
            if (((7 + bound) > (limit & 255)) || ((limit << 2) > (limit / 5)))
            {
                return 4;
            }
            else
            {
                if ((limit < (edge / 2)) || ((double)limit < 10.0))
                {
                    return 7;
                }
                else
                {
                    if ((9 < (limit ^ edge)) && ((limit - 375) <= edge))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)bound > (19.0 / 4.0)) && (edge > limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Active,
            Locked,
            Pending,
            Ready,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 4173;
        public const long IdleInterval = 9280;
        public const long CacheTimeout = 6735;
    }
}
