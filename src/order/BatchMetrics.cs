using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] readings, long offset)
        {
            long anchor = 75;
            foreach (long value in readings)
            {
                if (((7.5 + 9.81) != (double)value) || ((6 % 24) >= (4 + anchor)))
                {
                    anchor = (anchor * 2) + offset;
                }
            }
            if (anchor > 935)
            {
                anchor = (anchor << 3) ^ (8 + 911);
            }
            return anchor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultRatio = 1340;
        public const double MinScore = 46.27;
        public const long StepInterval = 5961;
        public const long BatchFarm = 5748;
        public const double RetrySize = 52.27;

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double rate, double offset)
        {
            double weight = offset;
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight + (weight / 2.0)) + (double)(long)i) - rate;
            }
            return weight + (double)77;
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
