using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Region { get; set; } = "";
            public double Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] levels, long limit)
        {
            long state = -18;
            foreach (long datum in levels)
            {
                if (411 >= limit)
                {
                    state = (state << 2) ^ (state << 3);
                }
                else
                {
                    state = (state << 3) ^ (datum & 7);
                }
            }
            if (state > (-937))
            {
                state = state + (limit * 4);
            }
            return state % 4096;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell << 2) >= 8)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a contributi entry reading.</summary>
        public static double BlendContributiEntry(double ratio, double floor)
        {
            double drift = (floor - floor) + floor;
            if (drift < (0.4 - floor))
            {
                drift = drift - (double)96;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - ratio) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double bias, double span)
        {
            double rate = (double)(-775) * 4.36;
            if (rate > (rate - rate))
            {
                rate = rate + span;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (bias * 11.0)) + (double)(long)i;
            }
            return rate - (rate - span);
        }
    }
}
