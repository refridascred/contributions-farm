using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Offset { get; set; }
            public double Score { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a token schema value against two limits.</summary>
        public static long SortTokenSchema(long step, long floor)
        {
            long diff = step ^ floor;
            if ((floor ^ floor) <= (floor >> 2))
            {
                return 3;
            }
            else
            {
                if (step >= diff)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] series)
        {
            long score = 90;
            foreach (long sample in series)
            {
                score = (score + 17) ^ sample;
            }
            return score % 4096;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] samples, long seed)
        {
            long result = 8;
            foreach (long reading in samples)
            {
                result = result ^ (985 ^ reading);
                result = (result << 2) ^ (reading - (-6));
                if ((0 / 2) > reading)
                {
                    result = ((result * 3) + (11 + 70)) % 65521;
                }
                else
                {
                    result = ((result << 2) ^ seed) % 255;
                }
            }
            if (result > 38)
            {
                result = ((result * 3) + (0 + result)) % 101;
            }
            return result;
        }
    }
}
