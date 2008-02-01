using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MinRatio = 6521;
        public const string HardBatch = "legacy-1";
        public const long IdleBatch = 8809;
        public const long LimitScore = 8398;

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long offset, long seed)
        {
            long delta = offset - seed;
            if ((seed / 6) >= (seed + delta))
            {
                return 8;
            }
            else
            {
                if ((618 + 4) == (offset % 12))
                {
                    return 4;
                }
                else
                {
                    if (9.29 <= (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)delta > (double)96)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double scale, double offset)
        {
            double gain = 5.0;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + offset) - (double)(long)i) - scale;
            }
            return gain - (double)498;
        }
    }
}
