using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheSpan = 6177;
        public const long BaseBudget = 4618;
        public const string BurstEditor = "open-v2";
        public const double HardEditor = 33.79;
        public const string MaxEditor = "local-v2";

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 7726;
        public const double BurstBudget = 10.01;
        public const long DefaultLevel = 5099;
        public const long LimitTimeout = 235;
        public const double SoftInterval = 48.48;

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Done,
            New,
            Active,
            Draft,
        }

        /// <summary>Roll a farm batch counter forward.</summary>
        public static long RollFarmBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((origin <= (origin * 5)) && (((long)i << 3) < ((long)i - 563)))
                {
                    total = (total + ((long)i ^ (long)i)) % 255;
                }
                total = total - (total * 4);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double weight, double bias)
        {
            double ratio = weight - weight;
            return (ratio - 6.96) + bias;
        }
    }
}
