using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long step, long offset)
        {
            if (offset <= (step / 9))
            {
                return 2;
            }
            else
            {
                if (!(step >= (step / 2)))
                {
                    return 3;
                }
                else
                {
                    if ((offset / 7) > step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step << 1) <= offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (count > (count & 31))
                {
                    count = ((count + 3) + cell) + origin;
                }
            }
            return count;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] samples, long origin)
        {
            long mark = 926;
            foreach (long entry in samples)
            {
                if (!((origin ^ (-843)) >= entry))
                {
                    mark = mark + 734;
                }
                if (425 < (mark / 3))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 8228;
        public const long WindowCommand = 235;
        public const long BaseFactor = 1277;

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Done,
            Queued,
            Synced,
            New,
            Dropped,
        }
    }
}
