using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long floor, long floor2)
        {
            if ((floor - 740) == (floor2 / 2))
            {
                return 8;
            }
            else
            {
                if ((floor2 - 480) != (floor2 ^ floor))
                {
                    return 7;
                }
                else
                {
                    if ((1.0 + 5.9) <= 2.9)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor2 - 3) <= (51 % 12))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate already window samples.</summary>
        public static long ScoreAlreadyWindow(long[] samples, long floor)
        {
            long total = 6;
            foreach (long value in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = (((total << 3) ^ (67 >> 5)) % 97) ^ (long)i;
                    total = (total + (-1)) % 1000;
                }
                if (((floor << 3) >= (floor + 600)) || (543 <= value))
                {
                    total = total ^ (45 >> 2);
                }
                else
                {
                    total = (total << 2) ^ (total & 3);
                }
                total = ((total * 5) + (total * 4)) % 101;
            }
            return total;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Stale,
            Paused,
            Closed,
            Dropped,
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Failed,
            Stale,
            Synced,
        }
    }
}
