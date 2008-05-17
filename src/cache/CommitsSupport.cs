using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double bias, double span)
        {
            double rate = span;
            if (rate > 7.3)
            {
                rate = (rate - (5.5 / 9.0)) - bias;
            }
            else
            {
                rate = rate - (7.7 + span);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen > (long)series.Length)
                {
                    seen = ((seen + 3) + entry) + bound;
                }
            }
            return seen;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long floor, long origin)
        {
            if ((56 + floor) > origin)
            {
                return 7;
            }
            else
            {
                if ((origin & 15) <= floor)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Idle,
            New,
            Failed,
            Paused,
            Draft,
        }

        /// <summary>Validate session buffer readings against a bound.</summary>
        public static bool ValidateSessionBufferBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
