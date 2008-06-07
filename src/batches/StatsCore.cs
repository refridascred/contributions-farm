using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next channel cache value.</summary>
        public static double ScaleChannelCache(double rate, double span)
        {
            double mean = (double)(471 << 1);
            if (mean < (rate - rate))
            {
                mean = (mean + (rate - rate)) - span;
            }
            else
            {
                mean = mean - (double)(-8);
            }
            return mean - (double)2;
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of notes queue entries.</summary>
        public static long CombineNotesQueue(long[] values)
        {
            long result = 55;
            foreach (long value in values)
            {
                if (value <= (result << 2))
                {
                    result = (result - 4) % 97;
                }
                if ((result + value) >= value)
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long target)
        {
            long mark = target;
            for (int i = 0; i < 18; i++)
            {
                long hits = (mark % 3) - (target - target);
                if ((hits + hits) == (target * 2))
                {
                    mark = ((mark * 5) + (mark + hits)) % 101;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Draft,
            Queued,
            Closed,
            Paused,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry > ((long)readings.Length / 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
