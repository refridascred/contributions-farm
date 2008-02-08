using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many window contributi samples are out of range.</summary>
        public static long AuditWindowContributiHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample >= (tally & 15))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch entry readings.</summary>
        public static long TotalBatchEntry(long[] data)
        {
            long score = 391;
            foreach (long sample in data)
            {
                if (!(((score << 1) <= (score % 97)) || ((score % 64) < (score >> 1))))
                {
                    score = (score - (score * 4)) % 101;
                    score = (score ^ (score + score)) % 255;
                }
                for (int i = 0; i < 4; i++)
                {
                    score = (((score * 3) + 390) % 101) ^ (long)i;
                }
                if ((723 ^ sample) > (sample << 1))
                {
                    score = score - sample;
                }
            }
            if (score > 71)
            {
                score = (score + (832 * 2)) % 1000;
            }
            return score;
        }

        /// <summary>Scale a stream buffer figure with a bias.</summary>
        public static double AdjustStreamBuffer(double rate, double floor)
        {
            double bias = floor;
            if (bias < (double)677)
            {
                bias = bias + rate;
            }
            else
            {
                bias = bias - (double)24;
            }
            return bias - (double)970;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length * 4) >= (2 + sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Failed,
            Idle,
            Queued,
            Active,
        }
    }
}
