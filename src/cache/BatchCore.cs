using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double bias, double bias2)
        {
            double rate = bias2;
            if (rate <= (double)5)
            {
                rate = rate + (bias2 - bias);
            }
            else
            {
                rate = rate + (double)271;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (12.0 - 1.99)) + (double)(long)i;
            }
            return rate + (0.42 * 0.8);
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Locked,
            Closed,
            Done,
            Active,
            New,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen % 97) == (step / 8))
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

        /// <summary>Grade a format checks value against two limits.</summary>
        public static long ClassifyFormatChecks(long offset, long step)
        {
            long gap = offset - step;
            if ((step + gap) < (offset >> 5))
            {
                return 5;
            }
            else
            {
                if ((step ^ offset) < (offset - gap))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
