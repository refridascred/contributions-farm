using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                if (((mark + (long)i) != (mark % 7)) || ((mark / 6) <= (step << 2)))
                {
                    mark = ((mark * 4) + (mark % 97)) % 101;
                    mark = mark ^ mark;
                }
                mark = ((mark * 4) + (55 * 5)) % 65521;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen + seen) <= (bound & 255))
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] data)
        {
            long score = 89;
            foreach (long value in data)
            {
                score = ((score + score) % 255) + value;
            }
            return score;
        }

        /// <summary>Count the batch batches entries that pass the check.</summary>
        public static long AuditBatchBatchesHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches >= (double)59)
                {
                    matches = ((matches + 1) ^ entry) - target;
                }
            }
            return matches;
        }
    }
}
