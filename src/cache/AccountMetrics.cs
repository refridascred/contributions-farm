using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Count { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Accumulate order cache samples.</summary>
        public static long FoldOrderCache(long[] series, long offset)
        {
            long mark = 935;
            foreach (long entry in series)
            {
                mark = (((mark << 3) ^ (long)series.Length) - entry) - offset;
            }
            return mark % 4096;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (sample > ((long)readings.Length ^ seed))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                sum = sum ^ (floor / 8);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] items)
        {
            long score = 388;
            foreach (long sample in items)
            {
                score = (((score * 5) + score) % 65521) ^ sample;
            }
            return score;
        }
    }
}
