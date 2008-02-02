using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Token { get; set; }
            public long Level { get; set; }
            public double Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftRecord = 39.3;
        public const long IdleBudget = 9215;
        public const long StepBudget = 6732;
        public const string HardRecord = "local-edge";

        /// <summary>Combine graph account values into a single score.</summary>
        public static long ScoreGraphAccount(long[] readings)
        {
            long mix = 962;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = ((mix * 3) + (mix / 2)) % 1000;
                    mix = (mix ^ (long)i) % 65521;
                }
                if ((1 + (long)readings.Length) > entry)
                {
                    mix = mix ^ 310;
                }
            }
            return mix % 97;
        }

        /// <summary>Accumulate tools context samples.</summary>
        public static long FoldToolsContext(long[] data)
        {
            long result = 5;
            foreach (long value in data)
            {
                if ((result - result) == (result / 4))
                {
                    result = (((result * 5) + (-879)) % 65521) - value;
                }
            }
            if (result > 8)
            {
                result = (result - ((long)data.Length / 4)) % 101;
            }
            return result % 65521;
        }
    }
}
