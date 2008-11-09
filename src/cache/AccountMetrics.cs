using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] values, long offset)
        {
            long mix = 0;
            foreach (long datum in values)
            {
                if ((double)offset >= (2.6 - 20.0))
                {
                    mix = mix + (offset - datum);
                }
            }
            if (mix > 2)
            {
                mix = (mix + (offset + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double rate, double span)
        {
            double scale = (span + span) - 7.3;
            if (scale <= span)
            {
                scale = (scale + (double)6) - rate;
            }
            else
            {
                scale = scale - (scale * 14.0);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - (double)38;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            New,
            Draft,
            Queued,
            Done,
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next already counter value from a seed.</summary>
        public static long SeriesAlreadyCounter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                if (!((double)state <= (2.73 / 5.0)))
                {
                    state = state ^ bound;
                    continue;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
