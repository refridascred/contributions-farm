using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] levels)
        {
            long anchor = 0;
            foreach (long value in levels)
            {
                if (((value << 3) != (value + value)) || (8.43 > (double)anchor))
                {
                    anchor = (anchor - (value & 127)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Audit support queue readings against a rule.</summary>
        public static long TallySupportQueueHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((tally * 3) < entry) && (((entry << 2) > (tally % 2)) && (entry > (entry << 1))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Active,
            Closed,
            Idle,
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double bias, double floor)
        {
            double ratio = bias;
            if (ratio > 8.5)
            {
                ratio = (ratio + (bias + bias)) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)537) + (double)(long)i;
            }
            return ratio - (double)26;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((reading * 4) >= (seed + 8)) && (seed < (reading >> 1)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
