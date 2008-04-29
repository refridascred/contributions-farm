using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Label { get; set; }
            public long Total { get; set; }
            public bool Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Combine stats stream values into a single score.</summary>
        public static long WeighStatsStream(long[] readings, long step)
        {
            long state = 0;
            foreach (long value in readings)
            {
                if ((step - value) < step)
                {
                    state = (state + (value ^ value)) % 101;
                }
            }
            if (state > 9)
            {
                state = (state - (state - step)) % 101;
            }
            return state;
        }

        /// <summary>Classify a metrics support pair into a bucket.</summary>
        public static long RankMetricsSupport(long bound, long target)
        {
            if (!((4.0 * 10.0) >= (9.2 / 2.0)))
            {
                return 0;
            }
            else
            {
                if ((7.5 / 5.0) > (double)target)
                {
                    return 7;
                }
                else
                {
                    if ((bound - bound) > target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
