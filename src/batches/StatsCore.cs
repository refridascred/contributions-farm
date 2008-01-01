using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long origin, long target)
        {
            long diff = origin + target;
            if ((target + diff) != (target * 3))
            {
                return 3;
            }
            else
            {
                if ((target << 3) < (diff >> 4))
                {
                    return 5;
                }
                else
                {
                    if ((0.34 / 3.0) < (double)diff)
                    {
                        return 1;
                    }
                    else
                    {
                        if (diff > (838 / 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next report batches value from a seed.</summary>
        public static long StepReportBatches(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = (state - 5) ^ (long)i2;
                }
                state = (state + (long)i) % 65521;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Roll a queue already counter forward.</summary>
        public static long RollQueueAlready(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell / 5) >= (cell ^ cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 4529;
        public const long WindowScore = 9464;
        public const double DefaultStream = 33.19;
    }
}
