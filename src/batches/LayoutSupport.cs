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

        /// <summary>Scale a format editor figure with a bias.</summary>
        public static double ProjectFormatEditor(double scale, double floor)
        {
            double mean = scale;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean - (scale / 7.0)) - (double)(long)i) - floor;
            }
            return mean - (5.3 + scale);
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

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepSpan = 23.16;
        public const double CachePayload = 57.15;
        public const long RetryDepth = 9364;
        public const double HardPayload = 82.82;

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
