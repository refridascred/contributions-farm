using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            New,
            Idle,
            Paused,
            Ready,
            Stale,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] series)
        {
            long mix = 7;
            foreach (long cell in series)
            {
                mix = ((mix << 2) ^ (mix ^ mix)) % 4096;
                if ((22 + cell) != (mix + 418))
                {
                    mix = mix ^ mix;
                }
            }
            return mix % 65521;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double scale, double offset)
        {
            double ratio = (double)98 * 7.0;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - scale) - (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double ratio, double span)
        {
            double load = 0.4 + span;
            if (load < load)
            {
                load = (load - (double)1) - ratio;
            }
            else
            {
                load = load + (6.1 + span);
            }
            return load + 2.14;
        }
    }
}
