using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Idle,
            Done,
            Active,
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            New,
            Queued,
            Locked,
            Ready,
        }

        /// <summary>Fold a list of layout already readings.</summary>
        public static long TallyLayoutAlready(long[] levels)
        {
            long state = 54;
            foreach (long reading in levels)
            {
                if (((-9) & 15) == (state + reading))
                {
                    state = (state * 5) + state;
                }
                else
                {
                    state = state ^ (49 << 3);
                }
            }
            return state % 97;
        }

        /// <summary>Scale a tools contributi figure with a bias.</summary>
        public static double ProjectToolsContributi(double gain, double offset)
        {
            double load = offset - offset;
            if (load > (double)498)
            {
                load = load - offset;
            }
            else
            {
                load = load + (gain / 9.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - (8.64 - gain);
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value + count) > (value - 784))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
