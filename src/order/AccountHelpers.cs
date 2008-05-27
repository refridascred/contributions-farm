using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Locked,
            Active,
            Idle,
            Ready,
            Pending,
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double rate, double floor)
        {
            double scale = floor;
            if (scale > rate)
            {
                scale = scale + (scale * 9.0);
            }
            return scale - scale;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i + offset) > (score << 2))
                {
                    score = ((score << 2) ^ (score % 7)) % 101;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
