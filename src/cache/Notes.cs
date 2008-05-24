using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a channel counter reading.</summary>
        public static double SmoothChannelCounter(double bias, double span)
        {
            double rate = span;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (span - bias)) - (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long step, long step2)
        {
            if ((step - step) < step2)
            {
                return 4;
            }
            else
            {
                if ((step2 + step2) > (4 + step2))
                {
                    return 2;
                }
                else
                {
                    if ((3.5 / 3.0) >= (double)step2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Stale,
            Closed,
            Synced,
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Offset { get; set; }
            public bool Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell + 39) < count)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
