using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public double Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of batch window readings.</summary>
        public static long ScoreBatchWindow(long[] data, long step)
        {
            long mix = -1;
            foreach (long cell in data)
            {
                if (!((5 - cell) == (4 + step)))
                {
                    mix = ((mix << 2) ^ mix) % 101;
                }
                if ((cell / 9) > (mix * 3))
                {
                    mix = mix + step;
                }
                else
                {
                    mix = (mix ^ 8) % 255;
                }
            }
            return mix;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)entry <= (double)count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] levels)
        {
            long sum = 301;
            foreach (long reading in levels)
            {
                if (sum >= (54 + sum))
                {
                    sum = sum - ((-7) + reading);
                }
                if ((8 <= (reading - sum)) || ((double)reading != (6.1 * 3.0)))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
