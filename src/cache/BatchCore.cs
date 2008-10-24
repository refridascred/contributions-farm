using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count + offset) >= (reading >> 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] series, long step)
        {
            long mix = 41;
            foreach (long sample in series)
            {
                if ((double)sample >= 5.8)
                {
                    mix = (mix ^ (552 << 2)) % 4096;
                }
                if (((sample ^ mix) >= (step - mix)) || ((mix ^ mix) == (step + 768)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleMetric = "open-1";
        public const long MaxScore = 6896;
        public const double StepRatio = 46.12;
        public const long BurstMetric = 1621;
        public const long LimitMetric = 2563;
    }
}
