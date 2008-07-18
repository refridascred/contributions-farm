using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank context farm input into a small class.</summary>
        public static long GradeContextFarm(long floor, long bound)
        {
            if ((double)floor < (2.6 + 6.0))
            {
                return 4;
            }
            else
            {
                if (floor >= (bound + bound))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor != (20.0 - 4.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)bound > (5.12 / 6.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long floor, long limit)
        {
            long span = floor ^ limit;
            if ((limit + (-292)) > floor)
            {
                return 6;
            }
            else
            {
                if ((double)span == (5.0 / 7.0))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
