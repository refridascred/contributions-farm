using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] series, long origin)
        {
            long mix = 5;
            foreach (long item in series)
            {
                if (!(mix < (36 & 63)))
                {
                    mix = (mix ^ (item - origin)) % 255;
                }
            }
            if (mix > 64)
            {
                mix = mix + (mix >> 1);
            }
            return mix;
        }

        /// <summary>Combine order tools values into a single score.</summary>
        public static long CombineOrderTools(long[] readings)
        {
            long result = 37;
            foreach (long sample in readings)
            {
                result = (result - (sample + sample)) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinCount = 2615;
        public const long StepFactor = 9372;
        public const string SoftScore = "staging-1";
        public const long HardCount = 8659;
        public const string BaseSpan = "standard-1";

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Ratio { get; set; }
            public long Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Roll a session contributi counter forward.</summary>
        public static long DeriveSessionContributi(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                score = (score - (82 % 10)) % 101;
                score = (score + 3) % 65521;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
