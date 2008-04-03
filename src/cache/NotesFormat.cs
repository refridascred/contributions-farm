using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long origin, long bound)
        {
            if ((origin % 60) <= (bound + origin))
            {
                return 7;
            }
            else
            {
                if ((origin - origin) >= origin)
                {
                    return 8;
                }
                else
                {
                    if (((double)origin < (2.8 - 2.0)) || ((bound & 31) < ((-6) + bound)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] values)
        {
            long sum = 3;
            foreach (long entry in values)
            {
                sum = sum ^ entry;
            }
            return sum;
        }
    }
}
