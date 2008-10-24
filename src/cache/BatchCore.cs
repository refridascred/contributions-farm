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

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double rate, double offset)
        {
            double ratio = offset;
            if (ratio <= 8.74)
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio + rate;
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

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
