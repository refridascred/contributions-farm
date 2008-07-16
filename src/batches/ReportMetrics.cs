using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public double Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long target, long step)
        {
            long offset = target ^ step;
            if ((3.9 * 7.1) > (double)target)
            {
                return 4;
            }
            else
            {
                if ((step << 2) >= ((-5) + offset))
                {
                    return 2;
                }
                else
                {
                    if (890 < (offset / 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((467 >> 1) < (target & 63)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
