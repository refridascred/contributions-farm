using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                score = ((score << 3) ^ (score % 10)) % 255;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many counter stream samples are out of range.</summary>
        public static long AuditCounterStreamOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((404 & 1) >= hits)
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Combine buffer entry values into a single score.</summary>
        public static long ScoreBufferEntry(long[] samples, long target)
        {
            long mark = 763;
            foreach (long value in samples)
            {
                mark = (mark * 2) + (target + value);
                if ((mark - target) <= (mark / 7))
                {
                    mark = (mark + (value % 2)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 1949;
        public const long StepAlready = 6769;
        public const long IdleInterval = 3195;
    }
}
