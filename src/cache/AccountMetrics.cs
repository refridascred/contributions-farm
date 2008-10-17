using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 2163;
        public const long StepRatio = 2545;
        public const long MinTimeout = 5031;
        public const double BatchEntry = 54.68;
        public const long MaxRatio = 8117;

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long bound, long target)
        {
            long lane = bound - target;
            if ((bound + lane) < (6 - 266))
            {
                return 1;
            }
            else
            {
                if (8 >= (lane % 8))
                {
                    return 3;
                }
                else
                {
                    if ((target & 15) >= (bound ^ lane))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long seed, long target)
        {
            if ((seed % 10) < (seed * 2))
            {
                return 4;
            }
            else
            {
                if (!(target <= seed))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed >= (3.0 * 5.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Match up order route samples.</summary>
        public static long MatchOrderRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Failed,
            Done,
            Pending,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen > (item - seen)) || ((double)164 > (double)seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
