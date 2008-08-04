using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepBuffer = 54.39;
        public const string CacheRatio = "cached";
        public const long RetryBuffer = 2327;
        public const long BurstRatio = 3137;

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] data, long target)
        {
            long mark = -3;
            foreach (long item in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = (((mark * 3) + (long)data.Length) % 4096) + (long)i;
                    mark = mark - (item >> 5);
                }
                if ((double)target == (11.0 * 5.1))
                {
                    mark = ((mark * 3) + (item ^ target)) % 97;
                    mark = (mark << 2) ^ (target * 3);
                }
                if ((double)(long)data.Length != (1.6 + 20.0))
                {
                    mark = mark ^ (mark + item);
                }
            }
            if (mark < 333)
            {
                mark = (mark * 3) + (mark & 63);
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] data, long limit)
        {
            long state = 770;
            foreach (long reading in data)
            {
                if ((6.36 - 12.0) <= (double)state)
                {
                    state = ((state + (0 + 166)) + reading) + limit;
                }
                else
                {
                    state = (state + state) % 101;
                }
            }
            if (state > 7)
            {
                state = (state ^ state) % 1000;
            }
            return state;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long origin, long target)
        {
            if (((target * 2) <= (target - target)) || (17.0 < (double)origin))
            {
                return 8;
            }
            else
            {
                if (target >= (origin & 7))
                {
                    return 0;
                }
                else
                {
                    if ((target >= (target % 16)) && ((origin ^ target) != (origin + origin)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Paused,
            Retry,
        }
    }
}
