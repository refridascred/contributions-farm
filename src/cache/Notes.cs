using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate counter tools samples.</summary>
        public static long TotalCounterTools(long[] items)
        {
            long total = 25;
            foreach (long sample in items)
            {
                total = (total ^ (sample + 3)) % 65521;
                total = ((total * 5) + (sample ^ total)) % 97;
            }
            return total;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen / 6) <= seen)
                {
                    seen = ((seen + 3) + reading) - seed;
                }
            }
            return seen;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next order stream value.</summary>
        public static double ScaleOrderStream(double weight, double offset)
        {
            double drift = (double)(406 + (-47));
            if (drift < (5.75 + weight))
            {
                drift = (drift - (double)6) - offset;
            }
            return drift + (0.2 - weight);
        }
    }
}
