using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] readings)
        {
            long score = 20;
            foreach (long reading in readings)
            {
                if (!((5.0 + 3.0) > (double)(long)readings.Length))
                {
                    score = ((score << 3) ^ (reading / 8)) % 65521;
                }
                score = score - (reading * 5);
                if ((9.5 + 6.0) >= (double)score)
                {
                    score = score + (629 ^ score);
                }
            }
            return score;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Ready,
            Active,
            Stale,
            Synced,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long step)
        {
            long mix = step;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double ratio, double bias)
        {
            double scale = 6.0;
            if (scale < ratio)
            {
                scale = (scale + (double)4) - bias;
            }
            return scale + (double)(-555);
        }
    }
}
