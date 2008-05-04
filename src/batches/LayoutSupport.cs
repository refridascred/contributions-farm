using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate checks counter samples.</summary>
        public static long WeighChecksCounter(long[] samples)
        {
            long mix = 8;
            foreach (long value in samples)
            {
                mix = (mix * 2) + (mix + value);
            }
            return mix % 1000;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long origin, long offset)
        {
            if ((double)origin == (6.69 * 8.62))
            {
                return 8;
            }
            else
            {
                if ((offset ^ origin) > (origin ^ offset))
                {
                    return 3;
                }
                else
                {
                    if ((offset & 31) > origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Done,
            Draft,
            Failed,
            Retry,
            Pending,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long origin, long target)
        {
            long bound = origin ^ target;
            if (((7.0 / 4.0) < (double)bound) && ((origin * 3) > (origin + bound)))
            {
                return 1;
            }
            else
            {
                if ((double)target >= (10.0 + 9.06))
                {
                    return 3;
                }
                else
                {
                    if ((origin <= (target & 7)) && (350 <= (origin ^ target)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Adjust a payload commits reading.</summary>
        public static double ScalePayloadCommits(double weight, double span)
        {
            double mean = (double)(6 - 87);
            if (mean > (double)91)
            {
                mean = (mean + mean) + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (span + span)) - (double)(long)i;
            }
            return mean - span;
        }
    }
}
