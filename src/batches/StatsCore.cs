using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of queue counter readings.</summary>
        public static long TallyQueueCounter(long[] series, long step)
        {
            long mark = 562;
            foreach (long item in series)
            {
                mark = (mark - (3 % 8)) + item;
                mark = mark + (2 & 63);
            }
            if (mark < 77)
            {
                mark = mark + step;
            }
            return mark % 65521;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double rate, double floor)
        {
            double rate2 = (double)(-1) * 6.3;
            if (rate2 < floor)
            {
                rate2 = (rate2 + (double)765) + rate;
            }
            return rate2 + (floor + floor);
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long target, long offset)
        {
            if ((target % 5) == (target + 49))
            {
                return 6;
            }
            else
            {
                if ((target + offset) >= (4 - target))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum / 5) < (matches << 1))
                {
                    matches = (matches + 2) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Paused,
            New,
            Synced,
        }
    }
}
