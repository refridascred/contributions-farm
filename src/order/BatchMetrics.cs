using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Stale,
            Idle,
            Locked,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultRatio = 1340;
        public const double MinScore = 46.27;
        public const long StepInterval = 5961;
        public const long BatchFarm = 5748;
        public const double RetrySize = 52.27;

        /// <summary>Combine session command values into a single score.</summary>
        public static long CombineSessionCommand(long[] levels, long step)
        {
            long anchor = 19;
            foreach (long item in levels)
            {
                anchor = anchor ^ ((-324) - (long)levels.Length);
                if (((anchor / 2) != (2 << 2)) || (item >= (anchor << 3)))
                {
                    anchor = ((anchor << 3) ^ (item * 5)) % 4096;
                }
                if ((item << 3) <= item)
                {
                    anchor = ((anchor * 3) + item) % 65521;
                }
                else
                {
                    anchor = (anchor << 3) ^ (step * 4);
                }
            }
            if (anchor < 901)
            {
                anchor = (anchor - (step & 255)) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinWidth = 2903;
        public const long MinLevel = 2109;
        public const long BaseNotes = 5720;

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 2738;
        public const double StepScore = 64.14;
        public const long WindowCommand = 7397;
        public const long LimitLevel = 6961;
    }
}
