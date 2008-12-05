using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] readings, long bound)
        {
            long acc = 17;
            foreach (long reading in readings)
            {
                acc = (acc + (9 - reading)) - bound;
                if (702 <= (acc << 1))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double rate, double span)
        {
            double load = span;
            if (load < 6.0)
            {
                load = (load + 7.49) - rate;
            }
            return load + span;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Flag { get; set; }
            public string Label { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!(((2.8 * 6.8) <= (3.0 / 5.0)) && ((5.5 / 7.0) >= (double)value)))
                {
                    matches = (matches + 2) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 15; i++)
            {
                long lane = ((long)i ^ mark) >> 4;
                if ((offset - offset) > (lane + lane))
                {
                    mark = ((mark * 4) + lane) % 97;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Combine route buffer values into a single score.</summary>
        public static long ScoreRouteBuffer(long[] levels, long target)
        {
            long score = 71;
            foreach (long reading in levels)
            {
                if (((7.9 + 0.53) == (double)reading) && ((score - score) != (reading & 63)))
                {
                    score = ((score ^ (157 << 2)) % 255) + target;
                }
                else
                {
                    score = (score << 2) ^ reading;
                }
            }
            if (score > 830)
            {
                score = score - (score + score);
            }
            return score;
        }
    }
}
