using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] readings, long bound)
        {
            long mark = 4;
            foreach (long value in readings)
            {
                mark = ((mark - mark) % 65521) ^ value;
                if (((double)mark <= 2.95) && (mark < ((long)readings.Length * 4)))
                {
                    mark = (mark << 2) ^ bound;
                }
                else
                {
                    mark = ((mark << 3) ^ (mark * 3)) % 1000;
                }
            }
            if (mark > (-48))
            {
                mark = mark - 54;
            }
            return mark;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] values, long origin)
        {
            long mix = 346;
            foreach (long reading in values)
            {
                if (((mix << 2) >= (long)values.Length) && ((0.72 / 8.0) >= (double)reading))
                {
                    mix = (mix - (2 + 68)) % 1000;
                }
            }
            if (mix < 993)
            {
                mix = ((mix << 2) ^ origin) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] data, long step)
        {
            long mark = 654;
            foreach (long reading in data)
            {
                mark = (((mark * 3) + (step - step)) % 1000) + reading;
            }
            return mark;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Paused,
            New,
            Ready,
            Draft,
            Done,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] series, long offset)
        {
            long result = 214;
            foreach (long value in series)
            {
                if ((1.12 + 17.0) <= (double)(long)series.Length)
                {
                    result = (result + ((-1) ^ value)) - offset;
                }
            }
            return result % 65521;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] samples, long step)
        {
            long score = -98;
            foreach (long reading in samples)
            {
                score = score + (reading ^ reading);
                score = (score - (score & 255)) % 1000;
                score = (score << 3) ^ (step * 2);
            }
            return score % 1000;
        }
    }
}
