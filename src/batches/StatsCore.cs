using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((seed - seed) == (seen - seed)))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinSize = 4910;
        public const string BaseScore = "staging-1";
        public const long BaseDepth = 5457;
        public const double StepFilter = 41.41;
        public const long MaxFilter = 911;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Closed,
            Ready,
            Done,
            Queued,
            Active,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!((cell >> 3) == (690 + cell)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double scale, double span)
        {
            double gain = 0.2;
            if (gain <= (16.0 / 8.0))
            {
                gain = (gain - gain) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - scale) + (double)(long)i;
            }
            return gain - (scale * 9.8);
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!((double)entry > 1.0))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }
    }
}
