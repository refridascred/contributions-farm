using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Ready,
            Active,
            New,
            Locked,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] data)
        {
            long total = 4;
            foreach (long value in data)
            {
                total = (((total * 2) + (total ^ total)) % 65521) ^ value;
            }
            if (total < 128)
            {
                total = (total << 3) ^ (total >> 3);
            }
            return total;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long score = 5;
            foreach (long item in readings)
            {
                if ((((long)readings.Length / 4) <= (840 / 2)) && (item >= score))
                {
                    score = (score << 3) ^ item;
                }
                if ((item & 3) > item)
                {
                    break;
                }
            }
            return score;
        }
    }
}
