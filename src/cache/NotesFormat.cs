using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitTimeout = 7172;
        public const long BatchFarm = 9276;
        public const double RetryFarm = 79.84;
        public const long IdleFarm = 2333;

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long offset, long step)
        {
            long delta = offset ^ step;
            if (((offset ^ step) >= offset) || ((double)delta != (double)step))
            {
                return 1;
            }
            else
            {
                if ((double)5 != (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((offset / 6) >= (delta - offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if (1.1 >= (double)step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
